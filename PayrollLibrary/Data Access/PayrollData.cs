using PayrollLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary.Data_Access
{
    public class PayrollData : SqliteDataAccess<Payroll>
    {
        public static int? GetLastId()
        {
            int? id = null;
            var item = QueryFirstOrDefault("SELECT ID FROM Payrolls ORDER BY ID DESC LIMIT 1", null);
            if (item != null)
            {
                id = item.ID;
            }
            return id;
        }
        public static Payroll GetDetailed(int id)
        {
            Payroll payroll = FindById(id);
            List<PayrollEmployee> payrollEmployees = PayrollEmployeeData.GetAll();
            List<Employee> employees = EmployeeData.GetAllDetailed();
            foreach (var pEmployee in payrollEmployees)
            {
                pEmployee.Employee = employees.FirstOrDefault(x => x.ID == pEmployee.EmployeeID);
            }

            payroll.PayrollEmployees = payrollEmployees.Where(x => x.PayrollID == payroll.ID).ToList();

            return payroll;
        }

        public static int DeletePayroll(int id)
        {
            var payrollEmpoyeeId = PayrollEmployeeData.GetAllIDFromPayroll(id);
            foreach (var pEmployeeId in payrollEmpoyeeId)
            {
                PayrollEmployeeData.Delete(pEmployeeId);
            }
            return Delete(id);
        }
    }
}
