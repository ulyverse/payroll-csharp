namespace PayrollLibrary.Model
{
    public class Payroll
    {
        public int ID { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public bool DetailedDeduction { get; set; }
    }
}
