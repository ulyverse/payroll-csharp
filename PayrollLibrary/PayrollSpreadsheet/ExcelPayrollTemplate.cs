using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary.PayrollSpreadsheet
{
    public class ExcelPayrollTemplate
    {
        public Cell? DateRange { get; set; }
        public Cell? Name { get; set; }
        public Cell? Department { get; set; }
        public Cell? Rate { get; set; }
        public Cell? NormalHours { get; set; }
        public Cell? Overtime { get; set; }
        public Cell? TotalHours { get; set; }
        public Cell? Date { get; set; }
        public Cell? SSS { get; set; }
        public Cell? PagIbig { get; set; }
        public Cell? PhilHealth { get; set; }
        public Cell? CashAdvanceAmountToPay { get; set; }
        public Cell? Snack { get; set; }
        public Cell? GrossPay { get; set; }
        public Cell? TotalDeductions { get; set; }
        public Cell? NetPay { get; set; }
        public Cell? PreviousCashAdvance { get; set; }
        public Cell? NextCashAdvance { get; set; }
    }
}
