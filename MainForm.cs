using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using Excel = Microsoft.Office.Interop.Excel;

namespace DataScraper
{
    public partial class MainForm : Form
    {
        private static MainForm _this = null;
        private static Worker _bgworker = null;
        public MainForm()
        {
            InitializeComponent();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                cList.Items.Add(c);
            }
            for (char c = '1'; c <= '9'; c++)
            {
                cList.Items.Add(c);
            }

            foreach(string d in StaticData.liveMintStockData)
            {
                clbStockData.Items.Add(d, true);
            }

            foreach (string d in StaticData.liveMintBalanceSheetHeader)
            {
                clbLiveMintBalanceSheet.Items.Add(d, true);
            }

            foreach (string d in StaticData.liveMintProfitLossData)
            {
                clbLiveMintProfitLoss.Items.Add(d, true);
            }

            foreach (string d in StaticData.liveMintCashFlowData)
            {
                clbLiveMintCashFlow.Items.Add(d, true);
            }

            foreach (string d in StaticData.liveMintQuaterlyData)
            {
                clbLiveMintExportQuaterly.Items.Add(d, true);
            }

            _this = this;
            _this.cbFinExp.Enabled = false;
            _this.cbHBL.Enabled = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdlg = new SaveFileDialog();
            sdlg.Filter = "Excel Files (*.xlsx)|*.xlsx";
            if (DialogResult.OK == sdlg.ShowDialog())
            {
                txtOut.Text = sdlg.FileName;
            }
        }

        private void btxExec_Click(object sender, EventArgs e)
        {
            if (0 < txtOut.Text.Length)
            {
                if (0 < cList.SelectedItems.Count)
                {
                    string selection = "";
                    foreach(var item in cList.SelectedItems)
                    {
                        selection += item.ToString();
                    }

                    if (cbFinExp.Checked || cbLivemint.Checked || cbHBL.Checked)
                    {
                        StaticData.selectedLiveMintStockData = null;
                        StaticData.selectedLiveMintBalanceSheet = null;
                        StaticData.selectedLiveMintProfitLoss = null;
                        StaticData.selectedLiveMintCashFlow = null;
                        StaticData.selectedLiveMintQuaterly = null;

                        if(cbExportStockData.Checked && 0 < clbStockData.SelectedItems.Count)
                        {
                            StaticData.selectedLiveMintStockData = new string[clbStockData.SelectedItems.Count];
                            int i = 0;
                            foreach (var item in clbStockData.SelectedItems)
                            {
                                StaticData.selectedLiveMintStockData[i] = item.ToString();
                                i++;
                            }
                        }

                        if (cbExportBalanceSheet.Checked && 0 < clbLiveMintBalanceSheet.SelectedItems.Count)
                        {
                            StaticData.selectedLiveMintBalanceSheet = new string[clbLiveMintBalanceSheet.SelectedItems.Count];
                            int i = 0;
                            foreach (var item in clbLiveMintBalanceSheet.SelectedItems)
                            {
                                StaticData.selectedLiveMintBalanceSheet[i] = item.ToString();
                                i++;
                            }
                        }

                        if (cbLiveMintProfitLoss.Checked && 0 < clbLiveMintProfitLoss.SelectedItems.Count)
                        {
                            StaticData.selectedLiveMintProfitLoss = new string[clbLiveMintProfitLoss.SelectedItems.Count];
                            int i = 0;
                            foreach (var item in clbLiveMintProfitLoss.SelectedItems)
                            {
                                StaticData.selectedLiveMintProfitLoss[i] = item.ToString();
                                i++;
                            }
                        }

                        if (cbExportLiveMintCashFlow.Checked && 0 < clbLiveMintCashFlow.SelectedItems.Count)
                        {
                            StaticData.selectedLiveMintCashFlow = new string[clbLiveMintCashFlow.SelectedItems.Count];
                            int i = 0;
                            foreach (var item in clbLiveMintCashFlow.SelectedItems)
                            {
                                StaticData.selectedLiveMintCashFlow[i] = item.ToString();
                                i++;
                            }
                        }

                        if (cbLiveMintExportQuaterly.Checked && 0 < clbLiveMintExportQuaterly.SelectedItems.Count)
                        {
                            StaticData.selectedLiveMintQuaterly = new string[clbLiveMintExportQuaterly.SelectedItems.Count];
                            int i = 0;
                            foreach (var item in clbLiveMintExportQuaterly.SelectedItems)
                            {
                                StaticData.selectedLiveMintQuaterly[i] = item.ToString();
                                i++;
                            }
                        }

                        Log("[Success] : Data fetching started");
                        cbLivemint.Enabled = false;
                        cbFinExp.Enabled = false;
                        cbHBL.Enabled = false;
                        btnBrowse.Enabled = false;
                        btxExec.Enabled = false;
                        cList.Enabled = false;
                        lblAll.Enabled = false;
                        lblNone.Enabled = false;

                        _bgworker = new Worker(cbLivemint.Checked, cbFinExp.Checked, cbHBL.Checked, selection);
                    }
                    else
                    {
                        Log("[ Error ] : Select atleast one data source");
                    }
                }
                else
                {
                    Log("[ Error ] : Select atleast one target company name group");
                }
            }
            else
            {
                Log("[ Error ] : Output location not specified");
            }
        }

        public static void DoExcel()
        {
            Excel.Application xlApp = new Excel.Application();
            if (null != xlApp)
            {
                int nSheet = 1;
                xlApp.DisplayAlerts = false;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;

                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);

                if (_this.cbLivemint.Checked)
                {
                    if (xlWorkBook.Worksheets.Count < nSheet)
                    {
                        xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.Add();
                    }
                    else
                    {
                        xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(nSheet);
                    }
                    nSheet++;

                    xlWorkSheet.Name = "LiveMint.com";

                    var l = _bgworker.GetLiveMintData();

                    var startCell = (Excel.Range)xlWorkSheet.Cells[1, 1];
                    var endCell = (Excel.Range)xlWorkSheet.Cells[l.GetLength(0), l.GetLength(1)];
                    var writeRange = xlWorkSheet.Range[startCell, endCell];
                    writeRange.Value2 = l;
                    writeRange.Columns.AutoFit();
                    writeRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;

                    foreach(var f in LiveMintData.HeaderColor1)
                    {
                        var sc = (Excel.Range)xlWorkSheet.Cells[1, f.Item1 + 1];
                        var ec = (Excel.Range)xlWorkSheet.Cells[1, f.Item2 + f.Item1];
                        var rang = xlWorkSheet.Range[sc, ec];
                        rang.Interior.ColorIndex = f.Item3;
                    }

                    foreach (var f in LiveMintData.HeaderColor2)
                    {
                        var sc = (Excel.Range)xlWorkSheet.Cells[2, f.Item1 + 1];
                        var ec = (Excel.Range)xlWorkSheet.Cells[2, f.Item2 + f.Item1];
                        var rang = xlWorkSheet.Range[sc, ec];
                        rang.Interior.ColorIndex = f.Item3;
                    }

                    foreach (var f in LiveMintData.FormatColor)
                    {
                        var sc = (Excel.Range)xlWorkSheet.Cells[3, f.Item1 + 1];
                        var ec = (Excel.Range)xlWorkSheet.Cells[l.GetLength(0), f.Item2 + f.Item1];
                        var rang = xlWorkSheet.Range[sc, ec];
                        rang.Interior.ColorIndex = f.Item3;
                    }
                }

                xlWorkBook.SaveAs(_this.txtOut.Text, Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close();
                xlApp = null;
                Log("[Success] : Saved excel");
            }
            
            _this.cbLivemint.Enabled = true;
            //_this.cbFinExp.Enabled = true;
            //_this.cbHBL.Enabled = true;
            _this.btnBrowse.Enabled = true;
            _this.btxExec.Enabled = true;
            _this.cList.Enabled = true;
            _this.lblAll.Enabled = true;
            _this.lblNone.Enabled = true;
        }

        public static void Log(string msg)
        {
            if (_this.txtLog.InvokeRequired)
            {
                _this.txtLog.Invoke(new LogDeligate(Log), new object[] { msg });
            }
            else
            {
                _this.txtLog.Text += msg;
                _this.txtLog.Text += "\r\n";
            }
        }

        private delegate void LogDeligate(string msg);

        private void lblAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cList.Items.Count; i++)
                cList.SetItemChecked(i, true);
        }

        private void lblNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < cList.Items.Count; i++)
                cList.SetItemChecked(i, false);
        }

        private void cbExportStockData_CheckedChanged(object sender, EventArgs e)
        {
            clbStockData.Enabled = cbExportStockData.Checked;
        }

        private void lblStockDataAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbStockData.Items.Count; i++)
                clbStockData.SetItemChecked(i, true);
        }

        private void lblStockDataNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbStockData.Items.Count; i++)
                clbStockData.SetItemChecked(i, false);
        }

        private void cbExportBalanceSheet_CheckedChanged(object sender, EventArgs e)
        {
            clbLiveMintBalanceSheet.Enabled = cbExportBalanceSheet.Checked;
        }

        private void lblSelectBalanceSheetAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbLiveMintBalanceSheet.Items.Count; i++)
                clbLiveMintBalanceSheet.SetItemChecked(i, true);
        }

        private void lblSelectBalanceSheetNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbLiveMintBalanceSheet.Items.Count; i++)
                clbLiveMintBalanceSheet.SetItemChecked(i, false);
        }

        private void cbLiveMintProfitLoss_CheckedChanged(object sender, EventArgs e)
        {
            clbLiveMintProfitLoss.Enabled = cbLiveMintProfitLoss.Checked;
        }

        private void lblLiveMintProfitLossAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbLiveMintProfitLoss.Items.Count; i++)
                clbLiveMintProfitLoss.SetItemChecked(i, true);
        }

        private void lblLiveMintProfitLossNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbLiveMintProfitLoss.Items.Count; i++)
                clbLiveMintProfitLoss.SetItemChecked(i, false);
        }

        private void cbExportLiveMintCashFlow_CheckedChanged(object sender, EventArgs e)
        {
            clbLiveMintCashFlow.Enabled = cbExportLiveMintCashFlow.Checked;
        }

        private void lblLiveMintCashFlowAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbLiveMintCashFlow.Items.Count; i++)
                clbLiveMintCashFlow.SetItemChecked(i, true);
        }

        private void lblLiveMintCashFlowNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbLiveMintCashFlow.Items.Count; i++)
                clbLiveMintCashFlow.SetItemChecked(i, false);
        }

        private void cbLiveMintExportQuaterly_CheckedChanged(object sender, EventArgs e)
        {
            clbLiveMintExportQuaterly.Enabled = cbLiveMintExportQuaterly.Checked;
        }

        private void lblLiveMintExportQuaterlyAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbLiveMintExportQuaterly.Items.Count; i++)
                clbLiveMintExportQuaterly.SetItemChecked(i, true);
        }

        private void lblLiveMintExportQuaterlyNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbLiveMintExportQuaterly.Items.Count; i++)
                clbLiveMintExportQuaterly.SetItemChecked(i, false);
        }
    }
}
