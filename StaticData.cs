using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScraper
{
    class StaticData
    {
        public static string[] liveMintBalanceSheetHeader = new string[] { "Share Capital", "Equity - Authorised", "Equity - Issued",
                "Equity Paid Up", "Equity Shares Forfeited", "Adjustments to Equity", "Preference Capital Paid Up", "Face Value",
                "Share Warrants & Outstandings", "Total Reserves", "Securities Premium", "Capital Reserves",
                "Profit & Loss Account Balance", "General Reserves", "Other Reserves", "Reserve excluding Revaluation Reserve",
                "Revaluation reserve", "Shareholder's Funds", "Minority Interest", "Long-Term Borrowings", "Secured Loans",
                "Non Convertible Debentures", "Converible Debentures & Bonds", "Packing Credit - Bank",
                "Inter Corporate & Security Deposit", "Term Loans - Banks", "Term Loans - Institutions", "Other Secured",
                "Unsecured Loans", "Fixed Deposits - Public", "Loans and advances from subsidiaries",
                "Inter Corporate Deposits (Unsecured)", "Foreign Currency Convertible Notes", "Long Term Loan in Foreign Currency",
                "Loans - Banks", "Loans - Govt", "Loans - Others", "Other Unsecured Loan", "Deferred Tax Assets / Liabilities",
                "Deferred Tax Assets1", "Deferred Tax Liability", "Other Long Term Liabilities", "Long Term Trade Payables",
                "Long Term Provisions", "Total Non-Current Liabilities", "Current Liabilities", "Trade Payables", "Sundry Creditors",
                "Acceptances", "Due to Subsidiaries- Trade Payables", "Other Current Liabilities", "Bank Overdraft / Short term credit",
                "Advances received from customers", "Interest Accrued But Not Due", "Share Application Money",
                "Current maturity of Debentures & Bonds", "Current maturity - Others", "Other Liabilities", "Short Term Borrowings",
                "Secured ST Loans repayable on Demands", "Working Capital Loans- Sec", "Buyers Credits - Unsec",
                "Commercial Borrowings- Unsec", "Other Unsecured Loans", "Short Term Provisions", "Proposed Equity Dividend",
                "Provision for Corporate Dividend Tax", "Provision for Tax", "Provision for post retirement benefits",
                "Preference Dividend", "Other Provisions", "Total Current Liabilities", "Total Liabilities", "ASSETS",
                "Gross Block1", "Less: Accumulated Depreciation", "Less: Impairment of Assets", "Net Block", "Lease Adjustment A/c",
                "Capital Work in Progress", "Non Current Investments", "Long Term Investment", "Quoted", "Unquoted",
                "Long Term Loans & Advances", "Other Non Current Assets", "Total Non-Current Assets",
                "Current Assets Loans & Advances", "Currents Investments", "Quoted", "Unquoted", "Inventories", "Raw Materials",
                "Work-in Progress", "Finished Goods", "Packing Materials", "Stores  and Spare", "Other Inventory", "Sundry Debtors",
                "Debtors more than Six months", "Debtors Others", "Cash and Bank", "Cash in hand", "Balances at Bank",
                "Other cash and bank balances", "Other Current Assets", "Interest accrued on Investments",
                "Interest accrued on Debentures", "Deposits with Government", "Interest accrued and or due on loans",
                "Prepaid Expenses", "Other current_assets", "Short Term Loans and Advances", "Advances recoverable in cash or in kind",
                "Advance income tax and TDS", "Amounts due from directors", "Due From Subsidiaries", "Inter corporate deposits",
                "Corporate Deposits", "Other Loans & Advances", "Total Current Assets",
                "Net Current Assets (Including Current Investments)", "Miscellaneous Expenses not written off", "Total Assets",
                "Contingent Liabilities", "Total Debt", "Book Value", "Adjusted Book Value" };



        public static string TrimData(string res, string path)
        {
            try
            {
                int pos = 0;
                string[] split = path.Split(",".ToCharArray());
                foreach (string s in split)
                {
                    pos = res.IndexOf(s, pos + 1);
                }
                return res.Substring(pos + 1);
            }
            catch
            {
                return "";
            }
        }
    }
}
