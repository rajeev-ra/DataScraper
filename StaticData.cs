using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScraper
{
    class StaticData
    {
        public static string[] selectedLiveMintStockData = null;
        public static string[] liveMintStockData = new string[] { "MARKET CAP (RS MN)", "P/E", "BOOK VALUE(RS)", "DIV (%)", "MARKET LOT",
            "INDUSTRY P/E", "EPS (TTM)", "P/C", "PRICE BOOK", "DIV YIELD (%)", "FACE VALUE", "DELIVERABLES (%)" };

        public static string[] selectedLiveMintBalanceSheet = null;
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

        public static string[] selectedLiveMintProfitLoss = null;
        public static string[] liveMintProfitLossData = new string[] { "Gross Sales", "Sales", "Job Work/ Contract Receipts",
            "Processing Charges / Service Income", "Revenue from property development", "Other Operational Income",
            "Less: Excise Duty", "Net Sales", "EXPENDITURE :", "Increase/Decrease in Stock", "Raw Material Consumed",
            "Opening Raw Materials", "Purchases Raw Materials", "Closing Raw Materials", "Other Direct Purchases / Brought in cost",
            "Other raw material cost", "Power & Fuel Cost", "Electricity & Power", "Oil, Fuel & Natural gas", "Coals etc",
            "Other power & fuel", "Employee Cost", "Salaries, Wages & Bonus", "Contributions to EPF & Pension Funds",
            "Workmen and Staff Welfare Expenses", "Other Employees Cost", "Other Manufacturing Expenses",
            "Sub-contracted / Out sourced services", "Processing Charges", "Repairs and Maintenance", "Packing Material Consumed",
            "Other Mfg Exp", "General and Administration Expenses", "Rent , Rates & Taxes", "Insurance", "Printing and stationery",
            "Professional and legal fees", "Traveling and conveyance", "Other Administration", "Selling and Distribution Expenses",
            "Advertisement & Sales Promotion", "Sales Commissions & Incentives", "Freight and Forwarding",
            "Handling and Clearing Charges", "Other Selling Expenses", "Miscellaneous Expenses", "Bad debts /advances written off",
            "Provision for doubtful debts", "Losson disposal of fixed assets(net)", "Losson foreign exchange fluctuations",
            "Losson sale of non-trade current investments", "Other Miscellaneous Expenses", "Less: Expenses Capitalised",
            "Total Expenditure", "Operating Profit (Excl OI)", "Other Income", "Interest Received", "Dividend Received",
            "Profit on sale of Fixed Assets", "Profits on sale of Investments", "Provision Written Back", "Foreign Exchange Gains",
            "Others", "Operating Profit", "Interest", "InterestonDebenture / Bonds", "Interest on Term Loan",
            "Intereston Fixed deposits", "Bank Charges etc", "Other Interest", "PBDT", "Depreciation",
            "Profit Before Taxation & Exceptional Items", "Exceptional Income / Expenses", "Profit Before Tax", "Provision for Tax",
            "Current Income Tax", "Deferred Tax", "Other taxes", "Profit After Tax", "Extra items", "Minority Interest",
            "Share of Associate", "Other Consolidated Items", "Consolidated Net Profit", "Adjustments to PAT", "Profit Balance B/F",
            "Appropriations", "General Reserves", "Proposed Equity Dividend", "Corporate dividend tax", "Other Appropriation",
            "Equity Dividend %", "Earnings Per Share", "Adjusted EPS" };

        public static string[] selectedLiveMintCashFlow = null;
        public static string[] liveMintCashFlowData = new string[] { "Profit Before Tax", "Adjustment", "Changes In working Capital",
            "Cash Flow after changes in Working Capital", "Cash Flow from Operating Activities", "Cash Flow from Investing Activities",
            "Cash Flow from Financing Activities", "Net Cash Inflow / Outflow", "Opening Cash & Cash Equivalents",
            "Cash & Cash Equivalent on Amalgamation / Take over / Merger", "Cash & Cash Equivalent of Subsidiaries under liquidations",
            "Translation adjustment on reserves / op cash balalces frgn subsidiaries", "Effect of Foreign Exchange Fluctuations",
            "Closing Cash & Cash Equivalent" };

        public static string[] selectedLiveMintQuaterly = null;
        public static string[] liveMintQuaterlyData = new string[] { "Audited / UnAudited", "Net Sales", "Total Expenditure",
            "PBIDT (Excl OI)", "Other Income", "Operating Profit", "Interest", "Exceptional Items", "PBDT", "Depreciation",
            "Profit Before Tax", "Tax", "Provisions and contingencies", "Profit After Tax", "Extraordinary Items",
            "Prior Period Expenses", "Other Adjustments", "Net Profit", "Minority Interest", "Shares of Associates",
            "Other related items", "Misc. Expenses Written off", "Consolidated Net Profit", "Equity Capital", "Face Value (IN RS)",
            "ReservesNA", "Basic Eps After Extraordinary Items", "Basic Eps Before Extraordinary Items", "No of Public Share Holdings",
            "% of Public Share Holdings", "PBIDTM% (Excl OI)", "PBIDTM%", "PBDTM%", "PBTM%", "PATM%" };

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
