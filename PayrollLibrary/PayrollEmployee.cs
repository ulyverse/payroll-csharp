﻿namespace PayrollLibrary
{
    public class PayrollEmployee
    {
        public int ID { get; set; }
        public int PayrollID { get; set; }
        public int EmployeeID { get; set; }
        public decimal GrossPay { get; set; }
        public decimal CurrentSSS { get; set; }
        public decimal CurrentPagIbig { get; set; }
        public decimal CurrentPhilHealth { get; set; }
        public decimal CurrentCashAdvance { get; set; }
        public decimal CurrentSnack { get; set; }
    }
}
