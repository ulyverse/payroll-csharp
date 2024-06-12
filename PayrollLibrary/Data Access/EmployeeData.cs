using PayrollLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary.Data_Access;

public class EmployeeData : SqliteDataAccess<Employee>
{
    public static Employee? Login(string username, string password)
    {
        return QueryFirstOrDefault("Select * FROM Employees WHERE username = @Username AND password = @Password",
            new { Username = username, Password = Helper.HashToMd5(password) });
    }

    public static List<Employee> GetAllDetailed()
    {
        List<Employee> employeeList = GetAll();

        List<Role> roleList = RoleData.GetAll();
        List<Department> departmentList = DepartmentData.GetAll();

        foreach (Employee employee in employeeList)
        {
            employee.Department = departmentList.Where(d => d.ID == employee.DepartmentID).FirstOrDefault();
            employee.Role = roleList.Where(r => r.ID == employee.RoleID).FirstOrDefault();
        }

        return employeeList;
    }
}
