using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.Xml;
using mshtml;

namespace DataScraper
{
    public class LiveMintData
    {
        private class jsonData
        {
            public string FINCODE { get; set; }
            public string S_NAME { get; set; }
            public string SCRIPCODE { get; set; }
            public string SYMBOL { get; set; }
        }

        private class StatData
        {
            public string companyName;
            public string bseCode;
            public string nseCode;
            public string bsePrice;
            public string nsePrice;
            public string marketCap;
            public string PbyE;
            public string bookVal;
            public string div;
            public string marketLot;
            public string industryPbyE;
            public string eps;
            public string PbyC;
            public string priceBook;
            public string divYield;
            public string faceVal;
            public string deliverables;
            public List<string> balanceSheetC = new List<string>();
            public List<string> balanceSheetS = new List<string>();
        }

        private object[,] _data = null;
        private List<StatData> _statList = new List<StatData>();
        private List<Tuple<string, string, string>> _dataList = new List<Tuple<string, string, string>>();

        public object[,] Execute()
        {
            _dataList.Add(new Tuple<string, string, string>("Company Name", "BSE CODE", "NSE CODE"));
            FetchWebData();

            _data = new object[_dataList.Count, 3];
            int i = 0;
            foreach(var d in _dataList)
            {
                _data[i, 0] = d.Item1;
                _data[i, 1] = d.Item2;
                _data[i, 2] = d.Item3;
                i++;
            }

            return _data;
        }


        private void FetchWebData()
        {
            char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();
            foreach(char c in chars)
            {
                string strPgCount = GetResponse("http://markets.livemint.com/ajaxPages/equity/EquityCompanyList.aspx?srchquote=" + c.ToString() + "&pageNo=1&PageSize=20&opt=page");
                int pageCount = Int32.Parse(strPgCount);

                for(int i = 1; i <= pageCount; i++)
                {
                    string strJson = GetResponse("http://markets.livemint.com/ajaxPages/equity/EquityCompanyList.aspx?srchquote=" + c.ToString() + "&pageNo="+ i.ToString() +"&PageSize=20");
                    var result = JsonConvert.DeserializeObject<List<jsonData>>(strJson);
                    foreach(var r in result)
                    {
                        StatData d = new StatData();
                        d.companyName = r.S_NAME;
                        d.bseCode = r.SCRIPCODE;
                        d.nseCode = r.SYMBOL;

                        MainForm.Log("Fetching : " + r.S_NAME);
                        string finCode = r.FINCODE;
                        finCode = finCode.Replace(' ', '-');
                        finCode = finCode.Replace("(", "");
                        finCode = finCode.Replace(")", "");
                        finCode = finCode.Replace(".", "");
                        ReadStockPrice(finCode, ref d);
                        ReadBalanceSheet(finCode, ref d);
                        _statList.Add(d);
                        //_dataList.Add(new Tuple<string, string, string>(r.S_NAME, r.SCRIPCODE, r.SYMBOL));
                    }
                }
            }            
        }


        private void ReadStockPrice(string finCode, ref StatData d)
        {
            string url = "http://markets.livemint.com/company-profile/" + finCode + "-stock-updates.aspx";
            string res = GetResponse(url);
            if(0 < res.Length)
            {
                d.bsePrice = GetData(res, "body,form,moneyWrapper,TopHead,listingBorder,leftlisting,wid3Col,fs20");
                d.nsePrice = GetData(res, "body,form,moneyWrapper,TopHead,listingBorder,rightlisting,wid3Col,fs20");

                d.marketCap = GetData(res, "body,form,moneyWrapper,rightCol2,CONSOLIDATED FIGURES,MARKET CAP (RS MN),fr");
                d.PbyE = GetData(res, "body,form,moneyWrapper,rightCol2,CONSOLIDATED FIGURES,P/E,fr");
                d.bookVal = GetData(res, "body,form,moneyWrapper,rightCol2,CONSOLIDATED FIGURES,BOOK VALUE(RS),fr");
                d.div = GetData(res, "body,form,moneyWrapper,rightCol2,CONSOLIDATED FIGURES,DIV (%),fr");
                d.marketLot = GetData(res, "body,form,moneyWrapper,rightCol2,CONSOLIDATED FIGURES,MARKET LOT,fr");
                d.industryPbyE = GetData(res, "body,form,moneyWrapper,rightCol2,CONSOLIDATED FIGURES,INDUSTRY P/E,fr");
                d.eps = GetData(res, "body,form,moneyWrapper,rightCol2,CONSOLIDATED FIGURES,EPS (TTM),fr");
                d.PbyC = GetData(res, "body,form,moneyWrapper,rightCol2,CONSOLIDATED FIGURES,P/C,fr");
                d.priceBook = GetData(res, "body,form,moneyWrapper,rightCol2,CONSOLIDATED FIGURES,PRICE BOOK,fr");
                d.divYield = GetData(res, "body,form,moneyWrapper,rightCol2,CONSOLIDATED FIGURES,DIV YIELD (%),fr");
                d.faceVal = GetData(res, "body,form,moneyWrapper,rightCol2,CONSOLIDATED FIGURES,FACE VALUE,fr");
                d.deliverables = GetData(res, "body,form,moneyWrapper,rightCol2,CONSOLIDATED FIGURES,DELIVERABLES (%),fr");
            }
            else
            {
                MainForm.Log("[ Error ] : Cannot fetch \"" + url + "\"");
            }
        }

        private void ReadBalanceSheet(string finCode, ref StatData d)
        {
            string url = "http://markets.livemint.com/company-profile/" + finCode + "-balance-sheet.aspx";

            string postData = "";
            
            // load default page
            string res = GetResponse(url);
            if (0 < res.Length)
            {
                postData += "&__VIEWSTATE=" + GetFormVal(res, "__VIEWSTATE");
                postData += "&__VIEWSTATEGENERATOR=" + GetFormVal(res, "__VIEWSTATEGENERATOR");
                postData += "&__EVENTARGUMENT=" + GetFormVal(res, "__EVENTARGUMENT");
                postData += "&__LASTFOCUS=" + GetFormVal(res, "__LASTFOCUS");
                postData += "&ctl00$ContentPlaceHolder1$ddlconvertdata=1";
            }
            else
            {
                MainForm.Log("[ Error ] : Cannot fetch \"" + url + "\"");
            }


            // change unit to crore
            res = GetPostResponse(url, "__EVENTTARGET=ctl00$ContentPlaceHolder1$ddlconvertdata" + postData);
            if (0 < res.Length)
            {
                res = StaticData.TrimData(res, "body,form,moneyWrapper,rightCol2,tabcontentbgfff");
                if (0 < res.Length)
                {
                    int pos = 0;
                    string strVal = "";
                    foreach (string header in StaticData.liveMintBalanceSheetHeader)
                    {
                        pos = res.IndexOf(header);
                        if (0 < pos)
                        {
                            pos = res.IndexOf("fincomondata", pos + 1);
                            if (0 < pos)
                            {
                                pos = res.IndexOf('>', pos + 1);
                                res = res.Substring(pos + 1);

                                pos = res.IndexOf('<');
                                strVal = res.Substring(0, pos);

                                strVal = strVal.Replace("&nbsp;", "");
                                strVal = strVal.Trim("\r\n ".ToCharArray());

                                d.balanceSheetC.Add(strVal);
                            }
                            else
                            {
                                d.balanceSheetC.Add("");
                            }
                        }
                        else
                        {
                            d.balanceSheetC.Add("");
                        }
                    }
                }
            }
            else
            {
                MainForm.Log("[ Error ] : Cannot fetch \"" + url + "\"");
            }

            // change sheet to standalone
            res = GetPostResponse(url, "__EVENTTARGET=ctl00$ContentPlaceHolder1$Standalone" + postData);
            if (0 < res.Length)
            {
                res = StaticData.TrimData(res, "body,form,moneyWrapper,rightCol2,tabcontentbgfff");
                if (0 < res.Length)
                {
                    int pos = 0;
                    string strVal = "";
                    foreach (string header in StaticData.liveMintBalanceSheetHeader)
                    {
                        pos = res.IndexOf(header);
                        if (0 < pos)
                        {
                            pos = res.IndexOf("fincomondata", pos + 1);
                            if (0 < pos)
                            {
                                pos = res.IndexOf('>', pos + 1);
                                res = res.Substring(pos + 1);

                                pos = res.IndexOf('<');
                                strVal = res.Substring(0, pos);

                                strVal = strVal.Replace("&nbsp;", "");
                                strVal = strVal.Trim("\r\n ".ToCharArray());

                                d.balanceSheetS.Add(strVal);
                            }
                            else
                            {
                                d.balanceSheetS.Add("");
                            }
                        }
                        else
                        {
                            d.balanceSheetS.Add("");
                        }
                    }
                }
            }
            else
            {
                MainForm.Log("[ Error ] : Cannot fetch \"" + url + "\"");
            }
        }

        private string GetResponse(string url)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Accept = "text / html,application / xhtml + xml,application / xml; q = 0.9,image / webp,*/*; q = 0.8";
                request.Headers.Add("Accept-Language", "en-US,en-GB;q=0.8,en;q=0.6");
                request.Host = "markets.livemint.com";
                request.Referer = "http://markets.livemint.com/equity/company-list.aspx?srchquote=A";
                request.UserAgent = "Mozilla / 5.0(Windows NT 6.3; WOW64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 56.0.2924.87 Safari / 537.36";
                request.Headers.Add("X-Requested-With", "XMLHttpRequest");
                
                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                return responseString;
            }
            catch
            {
                return "";
            }
        }

        private string GetPostResponse(string url, string postData)
        {
            try
            {
                url = url.ToLower();
                var data = Encoding.ASCII.GetBytes(postData);

                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                request.Headers.Add("Accept-Language", "en-US,en-GB;q=0.8,en;q=0.6");
                request.Host = "markets.livemint.com";
                request.Referer = url;
                request.UserAgent = "Mozilla / 5.0(Windows NT 6.3; WOW64) AppleWebKit / 537.36(KHTML, like Gecko) Chrome / 56.0.2924.87 Safari / 537.36";
                request.Headers.Add("Origin", "http://markets.livemint.com");
                request.Headers.Add("Cache-Control", "max-age=0");

                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                return responseString;
            }
            catch
            {
                return "";
            }
        }


        public static string GetData(string res, string path)
        {
            try
            {
                int pos = 0;
                string[] split = path.Split(",".ToCharArray());
                foreach (string s in split)
                {
                    pos = res.IndexOf(s, pos+1);
                }

                pos = res.IndexOf('>', pos+1);
                res = res.Substring(pos + 1);

                pos = res.IndexOf('<');
                res = res.Substring(0, pos);

                res = res.Replace("&nbsp;", "");
                return res.Trim("\r\n ".ToCharArray());
            }
            catch
            {
                return "";
            }
        }

        private static string GetFormVal(string res, string str)
        {
            try
            {
                int pos = 0;
                pos = res.IndexOf("body");
                pos = res.IndexOf("form", pos + 1);
                pos = res.IndexOf(str, pos + 1);
                pos = res.IndexOf("value", pos + 1);
                if ('=' == res.ElementAt(pos + 5))
                {
                    pos = res.IndexOf("=", pos + 1);
                    res = res.Substring(pos + 1);
                    pos = res.IndexOf("\"");
                    res = res.Substring(0, pos);
                    return res;
                }
                else
                {
                    return "";
                }
            }
            catch
            {
                return "";
            }
        } 
    }
}
