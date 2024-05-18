namespace PayrollLibrary
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public List<Attendance> Attendances { get; set; }

    }
}
