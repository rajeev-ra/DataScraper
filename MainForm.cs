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

            _this = this;
            _this.cbFinExp.Enabled = false;
            _this.cbHBL.Enabled = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog sdlg = new SaveFileDialog();
            sdlg.Filter = "Excel Files (*.xls)|*.xls";
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
                    var endCell = (Excel.Range)xlWorkSheet.Cells[l.Length / 3, 3];
                    var writeRange = xlWorkSheet.Range[startCell, endCell];
                    writeRange.Value2 = l;
                    writeRange.Columns.AutoFit();
                }

                xlWorkBook.SaveAs(_this.txtOut.Text, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
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
    }
}
