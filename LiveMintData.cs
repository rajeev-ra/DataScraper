using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Xml;

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
            public List<string> stockData = new List<string>();
            public string balanceYearC = "";
            public string balanceYearS = "";
            public List<string> balanceSheetC = new List<string>();
            public List<string> balanceSheetS = new List<string>();
            public string profitLossYearC = "";
            public string profitLossYearS = "";
            public List<string> profitLossC = new List<string>();
            public List<string> profitLossS = new List<string>();
            public string cashFlowYearC = "";
            public string cashFlowYearS = "";
            public List<string> cashFlowDataC = new List<string>();
            public List<string> cashFlowDataS = new List<string>();
            public string quaterC = "";
            public string quaterS = "";
            public List<string[]> quaterlyDataC = new List<string[]>();
            public List<string[]> quaterlyDataS = new List<string[]>();
            public string shareYear = "";
            public string[] noOfShares = new string[4];
        }

        public static List<Tuple<int, int, int>> HeaderColor1 = new List<Tuple<int, int, int>>();
        public static List<Tuple<int, int, int>> HeaderColor2 = new List<Tuple<int, int, int>>();
        public static List<Tuple<int, int, int>> FormatColor = new List<Tuple<int, int, int>>();

        private int _numCol = 0;
        private object[,] _data = null;
        private List<StatData> _statList = new List<StatData>();

        public object[,] Execute(string selection)
        {
            //FetchWebData(selection);
            ArrangeData();
            SetFormat(_numCol);
            return _data;
        }

        private void FetchWebData(string selection)
        {
            char[] chars = selection.ToCharArray();
            foreach(char c in chars)
            {
                string strPgCount = GetResponse("http://markets.livemint.com/ajaxPages/equity/EquityCompanyList.aspx?srchquote=" + c.ToString() + "&pageNo=1&PageSize=20&opt=page");
                int pageCount = Int32.Parse(strPgCount);

                for(int i = 1; i <= 1; i++)
                {
                    string strJson = GetResponse("http://markets.livemint.com/ajaxPages/equity/EquityCompanyList.aspx?srchquote=" + c.ToString() + "&pageNo="+ i.ToString() +"&PageSize=20");
                    var result = JsonConvert.DeserializeObject<List<jsonData>>(strJson);
                    //foreach(var r in result)
                    var r = result[0];
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
                        ReadProfitLoss(finCode, ref d);
                        ReadCashFlowData(finCode, ref d);
                        ReadQuaterlyData(finCode, ref d);
                        ReadNoOfShares(finCode, ref d);

                        _statList.Add(d);
                    }
                }
            }            
        }


        private static void ReadStockPrice(string finCode, ref StatData d)
        {
            string url = "http://markets.livemint.com/company-profile/" + finCode + "-stock-updates.aspx";
            string res = GetResponse(url);
            if(0 < res.Length)
            {
                d.bsePrice = GetData(res, "body,form,moneyWrapper,TopHead,listingBorder,leftlisting,wid3Col,fs20");
                d.nsePrice = GetData(res, "body,form,moneyWrapper,TopHead,listingBorder,rightlisting,wid3Col,fs20");

                res = StaticData.TrimData(res, "body,form,moneyWrapper,rightCol2,CONSOLIDATED FIGURES");
                if (0 < res.Length)
                {
                    foreach (string header in StaticData.liveMintStockData)
                    {
                        d.stockData.Add(GetData(ref res, header, "fr"));
                    }
                }
            }
            else
            {
                MainForm.Log("[ Error ] : Cannot fetch \"" + url + "\"");
            }
        }

        private static void ReadBalanceSheet(string finCode, ref StatData d)
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
                    d.balanceYearC = GetData(res, "Particulars,class,<b>");
                    foreach (string header in StaticData.liveMintBalanceSheetHeader)
                    {
                        d.balanceSheetC.Add(GetData(ref res, header, "fincomondata"));
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
                    d.balanceYearS = GetData(res, "Particulars,class,<b>");
                    foreach (string header in StaticData.liveMintBalanceSheetHeader)
                    {
                        d.balanceSheetS.Add(GetData(ref res, header, "fincomondata"));
                    }
                }
            }
            else
            {
                MainForm.Log("[ Error ] : Cannot fetch \"" + url + "\"");
            }
        }

        private static void ReadProfitLoss(string finCode, ref StatData d)
        {
            string url = "http://markets.livemint.com/company-profile/" + finCode + "-profit-loss-account.aspx";

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
                    d.profitLossYearC = GetData(res, "Particulars,class");
                    foreach (string header in StaticData.liveMintProfitLossData)
                    {
                        d.profitLossC.Add(GetData(ref res, header, "fincomondata"));
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
                    d.profitLossYearS = GetData(res, "Particulars,class");
                    foreach (string header in StaticData.liveMintProfitLossData)
                    {
                        d.profitLossS.Add(GetData(ref res, header, "fincomondata"));
                    }
                }
            }
            else
            {
                MainForm.Log("[ Error ] : Cannot fetch \"" + url + "\"");
            }
        }

        private static void ReadCashFlowData(string finCode, ref StatData d)
        {
            string url = "http://markets.livemint.com/company-profile/" + finCode + "-cash-flow.aspx";

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
                    d.cashFlowYearC = GetData(res, "Particulars,class");
                    foreach (string header in StaticData.liveMintCashFlowData)
                    {
                        d.cashFlowDataC.Add(GetData(ref res, header, "fincomondata"));
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
                    d.cashFlowYearS = GetData(res, "Particulars,class");
                    foreach (string header in StaticData.liveMintCashFlowData)
                    {
                        d.cashFlowDataS.Add(GetData(ref res, header, "fincomondata"));
                    }
                }
            }
            else
            {
                MainForm.Log("[ Error ] : Cannot fetch \"" + url + "\"");
            }
        }

        private static void ReadQuaterlyData(string finCode, ref StatData d)
        {
            string url = "http://markets.livemint.com/company-profile/" + finCode + "-quarterly-results.aspx";

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
                postData += "&ctl00$ContentPlaceHolder1$ddlYearDropDown=8";
            }
            else
            {
                MainForm.Log("[ Error ] : Cannot fetch \"" + url + "\"");
            }


            // change unit to crore
            res = GetPostResponse(url, "__EVENTTARGET=ctl00$ContentPlaceHolder1$CompNews" + postData);
            if (0 < res.Length)
            {
                res = StaticData.TrimData(res, "body,form,moneyWrapper,rightCol2,tabcontentbgfff");
                if (0 < res.Length)
                {
                    d.quaterC = GetData(res, "Particulars,class,<b>");
                    foreach (string header in StaticData.liveMintQuaterlyData)
                    {
                        d.quaterlyDataC.Add(GetQuaterlyData(ref res, header));
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
                    d.quaterS = GetData(res, "Particulars,class,<b>");
                    foreach (string header in StaticData.liveMintQuaterlyData)
                    {
                        d.quaterlyDataS.Add(GetQuaterlyData(ref res, header));
                    }
                }
            }
            else
            {
                MainForm.Log("[ Error ] : Cannot fetch \"" + url + "\"");
            }
        }

        private static void ReadNoOfShares(string finCode, ref StatData d)
        {
            string url = "http://markets.livemint.com/company-profile/" + finCode + "-shareholding.aspx";

            string postData = "";

            // load default page
            string res = GetResponse(url);
            if (0 < res.Length)
            {
                postData += "&__VIEWSTATE=" + GetFormVal(res, "__VIEWSTATE");
                postData += "&__VIEWSTATEGENERATOR=" + GetFormVal(res, "__VIEWSTATEGENERATOR");
                postData += "&__EVENTARGUMENT=" + GetFormVal(res, "__EVENTARGUMENT");
                postData += "&__LASTFOCUS=" + GetFormVal(res, "__LASTFOCUS");
                postData += "&ctl00$ContentPlaceHolder1$cursectag=PERSHARES";
            }
            else
            {
                MainForm.Log("[ Error ] : Cannot fetch \"" + url + "\"");
            }


            // switch to pershare
            res = GetPostResponse(url, "__EVENTTARGET=ctl00$ContentPlaceHolder1$A2" + postData);
            if (0 < res.Length)
            {
                d.shareYear = GetData(res, "body,form,moneyWrapper,rightCol2,ContentPlaceHolder1_InnerTable,thead,Particulars,class");
                res = StaticData.TrimData(res, "body,form,moneyWrapper,rightCol2,ContentPlaceHolder1_InnerTable,tbody,Grand Total,</td>");
                if (0 < res.Length)
                {
                    int pos = res.IndexOf("</tr>");
                    if(0 < pos)
                    {
                        res = res.Substring(0, pos);

                        for (int i = 0; i < 4; i++)
                        {
                            pos = res.IndexOf('>');
                            res = res.Substring(pos + 1);

                            pos = res.IndexOf('>');
                            res = res.Substring(pos + 1);

                            pos = res.IndexOf('<');
                            d.noOfShares[i] = res.Substring(0, pos);
                        }

                    }
                }
            }
            else
            {
                MainForm.Log("[ Error ] : Cannot fetch \"" + url + "\"");
            }
        }

        private static string GetResponse(string url)
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

        private static string GetPostResponse(string url, string postData)
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

        public static string GetData(ref string res, string var, string path)
        {
            string retVal = "";
            int pos = res.IndexOf(var);
            if (0 < pos)
            {
                pos = res.IndexOf(path, pos + 1);
                if (0 < pos)
                {
                    pos = res.IndexOf('>', pos + 1);
                    res = res.Substring(pos + 1);

                    pos = res.IndexOf('<');
                    retVal = res.Substring(0, pos);

                    retVal = retVal.Replace("&nbsp;", "");
                    retVal = retVal.Trim("\r\n ".ToCharArray());
                }
            }
            return retVal;
        }

        public static string[] GetQuaterlyData(ref string res, string var)
        {
            string[] retVal = new string[8];
            try
            {
                int pos = res.IndexOf(var);
                if (0 < pos)
                {
                    pos = res.IndexOf('>', pos + 1);
                    res = res.Substring(pos + 1);

                    pos = res.IndexOf("fintabelsrowsdata");
                    string searchStr = res.Substring(0, pos);

                    for (int i = 0; i < 8; i++)
                    {
                        pos = searchStr.IndexOf('>');
                        searchStr = searchStr.Substring(pos + 1);

                        pos = searchStr.IndexOf('<');
                        retVal[i] = searchStr.Substring(0, pos);

                        pos = searchStr.IndexOf('>');
                        searchStr = searchStr.Substring(pos + 1);
                    }
                }
            }
            catch
            {
            }
            return retVal;
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

        private static int GetYearVal(string quater)
        {
            try
            {
                int pos = quater.IndexOf('2');
                string mon = quater.Substring(0, pos);

                int yearVal = 4 * int.Parse(quater.Substring(pos + 1));
                switch (mon.ToLower())
                {
                    case "jun":
                        yearVal += 1;
                        break;
                    case "sept":
                        yearVal += 2;
                        break;
                    case "dec":
                        yearVal += 3;
                        break;
                }
                return yearVal;
            }
            catch
            { }

            return 0;
        }

        private static string GetQuaterFromVal(int i)
        {
            string quater = "";
            switch(i%4)
            {
                case 0:
                    quater = "Mar ";
                    break;
                case 1:
                    quater = "Jun ";
                    break;
                case 2:
                    quater = "Sept ";
                    break;
                case 3:
                    quater = "Dec ";
                    break;
            }

            quater += (i / 4).ToString();
            return quater;
        }

        private void ArrangeData()
        {
            _numCol = 5 + StaticData.liveMintStockData.Count() + 2 + 2 * StaticData.liveMintBalanceSheetHeader.Count() +
                2 + 2 * StaticData.liveMintCashFlowData.Count() + 2 + 2 * StaticData.liveMintProfitLossData.Count() + 2
                + 16 + 16 * StaticData.liveMintQuaterlyData.Count() + 20;

            _data = new object[_statList.Count() + 2, _numCol];

            _data[1, 0] = "Company Name";
            _data[1, 1] = "BSE CODE";
            _data[1, 2] = "NSE CODE";
            _data[1, 3] = "BSE Price";
            _data[1, 4] = "NSE Price";

            int i = 5;
            foreach (string header in StaticData.liveMintStockData)
            {
                _data[1, i] = header;
                i++;
            }

            for (int j = 0; j < 2; j++)
            {
                _data[1, i] = "Year";
                i++;

                foreach (string header in StaticData.liveMintBalanceSheetHeader)
                {
                    _data[1, i] = header;
                    i++;
                }
            }

            for (int j = 0; j < 2; j++)
            {
                _data[1, i] = "Year";
                i++;

                foreach (string header in StaticData.liveMintProfitLossData)
                {
                    _data[1, i] = header;
                    i++;
                }
            }

            for (int j = 0; j < 2; j++)
            {
                _data[1, i] = "Year";
                i++;

                foreach (string header in StaticData.liveMintCashFlowData)
                {
                    _data[1, i] = header;
                    i++;
                }
            }

            for (int j = 0; j < 16; j++)
            {
                _data[1, i] = "Year";
                i++;

                foreach (string header in StaticData.liveMintQuaterlyData)
                {
                    _data[1, i] = header;
                    i++;
                }
            }

            _data[1, i] = "Year";
            _data[1, i + 1] = "No of shares";

            int k = 2;

            foreach(var d in _statList)
            {
                _data[k, 0] = d.companyName;
                _data[k, 1] = d.bseCode;
                _data[k, 2] = d.nseCode;
                _data[k, 3] = d.bsePrice;
                _data[k, 4] = d.nsePrice;

                i = 5;
                foreach (string d2 in d.stockData)
                {
                    _data[k, i] = d2;
                    i++;
                }

                _data[k, i] = d.balanceYearC;
                i++;

                foreach(string d2 in d.balanceSheetC)
                {
                    _data[k, i] = d2;
                    i++;
                }

                _data[k, i] = d.balanceYearS;
                i++;

                foreach (string d2 in d.balanceSheetS)
                {
                    _data[k, i] = d2;
                    i++;
                }

                _data[k, i] = d.profitLossYearC;
                i++;

                foreach (string d2 in d.profitLossC)
                {
                    _data[k, i] = d2;
                    i++;
                }

                _data[k, i] = d.profitLossYearS;
                i++;

                foreach (string d2 in d.profitLossS)
                {
                    _data[k, i] = d2;
                    i++;
                }

                _data[k, i] = d.cashFlowYearC;
                i++;

                foreach (string d2 in d.cashFlowDataC)
                {
                    _data[k, i] = d2;
                    i++;
                }

                _data[k, i] = d.cashFlowYearS;
                i++;

                foreach (string d2 in d.cashFlowDataS)
                {
                    _data[k, i] = d2;
                    i++;
                }

                int year = GetYearVal(d.quaterC);

                foreach(var d2 in d.quaterlyDataC)
                {
                    _data[k, i] = GetQuaterFromVal(year);
                    i++;
                    year--;

                    foreach(string d3 in d2)
                    {
                        _data[k, i] = d3;
                        i++;
                    }
                }

                year = GetYearVal(d.quaterS);

                foreach (var d2 in d.quaterlyDataS)
                {
                    _data[k, i] = GetQuaterFromVal(year);
                    i++;
                    year--;

                    foreach (string d3 in d2)
                    {
                        _data[k, i] = d3;
                        i++;
                    }
                }

                _data[k, i] = d.shareYear;
                _data[k, i + 1] = d.noOfShares;

                k++;
            }

        }

        private static void SetFormat(int col)
        {
            HeaderColor1.Add(new Tuple<int, int, int>(0, col, 1));

            HeaderColor2.Add(new Tuple<int, int, int>(0, 1, 8));
            HeaderColor2.Add(new Tuple<int, int, int>(1, 2, 2));
            HeaderColor2.Add(new Tuple<int, int, int>(3, 2, 35));
            HeaderColor2.Add(new Tuple<int, int, int>(5, 12, 36));
            HeaderColor2.Add(new Tuple<int, int, int>(17, 1, 15));
            HeaderColor2.Add(new Tuple<int, int, int>(18, 128, 24));
        }
    }
}
