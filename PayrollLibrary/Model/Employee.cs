namespace PayrollLibrary.Model
{
    public class Employee
    {
        public int ID { get; set; }
        public int DepartmentID { get; set; }
        public int RoleID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [ExcludeProperty]
        public string FullName => $"{FirstName} {LastName}";
        public DateOnly Birthdate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } = "";
        public decimal Salary { get; set; }
        public decimal Balance { get; set; }
        public decimal CashAdvance { get; set; }
        public decimal Snack { get; set; }
        public decimal SSS { get; set; }
        public decimal PagIbig { get; set; }
        public decimal PhilHealth { get; set; }
        public bool IsActive { get; set; }
        [ExcludeProperty]
        public Role? Role { get; set; }
        [ExcludeProperty]
        public Department? Department { get; set; }
    }
}