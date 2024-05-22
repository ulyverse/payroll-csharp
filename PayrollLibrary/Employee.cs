namespace PayrollLibrary
{
    public class Employee
    {
        public int ID { get; set; }
        public int DepartmentID { get; set; }
        public int RoleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly Birthdate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public decimal Salary { get; set; }
        public decimal CashAdvance { get; set; }
        public decimal Balance { get; set; }
        public decimal SSS { get; set; }
        public decimal PagIbig { get; set; }
        public decimal PhilHealth { get; set; }
        public List<Attendance> Attendances { get; set; }

    }
}
