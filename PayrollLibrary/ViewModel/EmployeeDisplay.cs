using PayrollLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary.ViewModel
{
    public class EmployeeDisplay
    {
        public EmployeeDisplay(Employee employee)
        {
            if (employee == null)
                return;
            ID = employee.ID;
            Name = employee.FullName;
            Birthdate = employee.Birthdate;
            if (employee.Department != null)
                Department = employee.Department.Name;
            if (employee.Role != null)
                Role = employee.Role.Name;
            Salary = employee.Salary;
            Balance = employee.Balance;
            SSS = employee.SSS;
            PagIbig = employee.PagIbig;
            PhilHealth = employee.PhilHealth;
            CashAdv = employee.CashAdvance;
            Snack = employee.Snack;
        }
        public int ID { get; set; }
        public string? Name { get; set; }
        public DateOnly Birthdate { get; set; }
        public string Department { get; set; } = "";
        public string Role { get; set; } = "";
        public decimal Salary { get; set; }
        public decimal Balance { get; set; }
        public decimal CashAdv { get; set; }
        public decimal Snack { get; set; }
        public decimal SSS { get; set; }
        public decimal PagIbig { get; set; }
        public decimal PhilHealth { get; set; }
    }
}
