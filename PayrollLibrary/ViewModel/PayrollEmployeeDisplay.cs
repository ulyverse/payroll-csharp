using PayrollLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary.ViewModel
{
    public class PayrollEmployeeDisplay
    {
        public PayrollEmployeeDisplay(PayrollEmployee payrollEmployee)
        {
            var employee = payrollEmployee.Employee;
            EmployeeID = employee.ID;

            Name = employee.FullName;
            if (employee.Department != null)
                Department = employee.Department.Name;

            Rate = employee.Salary;
            NormalHours = payrollEmployee.CurrentNormalHours;
            Overtime = payrollEmployee.CurrentOvertimeHours;

            SSS = payrollEmployee.CurrentSSS;
            PagIbig = payrollEmployee.CurrentPagIbig;
            PhilHealth = payrollEmployee.CurrentPhilHealth;

            CashAdvance = payrollEmployee.CurrentCashAdvance;
            Snack = payrollEmployee.CurrentSnack;
            Balance = payrollEmployee.CurrentBalance;

            CalculateTotalDeductions();
            CalculateGrossPay();
        }

        public PayrollEmployeeDisplay(Employee employee, bool detailedDeduction = false)
        {
            EmployeeID = employee.ID;
            Name = employee.FullName;
            if (employee.Department != null)
                Department = employee.Department.Name;

            Rate = employee.Salary;
            if (detailedDeduction)
            {
                SSS = employee.SSS;
                PagIbig = employee.PagIbig;
                PhilHealth = employee.PhilHealth;
            }
            CashAdvance = employee.CashAdvance;
            Snack = employee.Snack;
            Balance = employee.Balance;

            CalculateTotalDeductions();
            CalculateGrossPay();
            Attendances = new List<Attendance>();
        }
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string? Department { get; set; }
        public decimal Rate { get; set; }
        public double NormalHours { get; set; }
        public double Overtime { get; set; }
        public decimal GrossPay { get; set; }
        public decimal SSS { get; set; }
        public decimal PagIbig { get; set; }
        public decimal PhilHealth { get; set; }
        public decimal Balance { get; set; }
        public decimal CashAdvance { get; set; }
        public decimal Snack { get; set; }
        public decimal TotalDeductions { get; set; }
        public decimal NetPay { get; set; }
        public List<Attendance> Attendances { get; set; }


        public void CalculateGrossPay()
        {
            decimal overtimeMultiplier = 1;
            decimal normalPay = (decimal)NormalHours * Rate;
            decimal overtimePay = (decimal)Overtime * (Rate * overtimeMultiplier);
            GrossPay = normalPay + overtimePay;
            CalculateNetPay();
        }

        private void CalculateNetPay()
        {
            NetPay = GrossPay - TotalDeductions;
        }

        private void CalculateTotalDeductions()
        {
            decimal totalDeductions = 0;
            totalDeductions += SSS;
            totalDeductions += PagIbig;
            totalDeductions += PhilHealth;
            totalDeductions += Balance;
            totalDeductions += CashAdvance;
            totalDeductions += Snack;
            TotalDeductions = totalDeductions;
        }

        public double GetTotalHours()
        {
            return NormalHours + Overtime;
        }
    }
}
