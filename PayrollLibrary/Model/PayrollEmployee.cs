namespace PayrollLibrary.Model
{
    public class PayrollEmployee
    {
        public int ID { get; set; }
        public int PayrollID { get; set; }
        public int EmployeeID { get; set; }
        public double CurrentNormalHours { get; set; }
        public double CurrentOvertimeHours { get; set; }
        public decimal CurrentSSS { get; set; }
        public decimal CurrentPagIbig { get; set; }
        public decimal CurrentPhilHealth { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal CurrentCashAdvance { get; set; }
        public decimal CurrentSnack { get; set; }
        [ExcludeProperty]
        public Employee Employee { get; set; }
    }
}
