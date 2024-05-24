using PayrollLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary.Data_Access;

public class EmployeeDataAccess : SqliteDataAccess<Employee>
{
    public static Employee? Login(string username, string password)
    {
        return QueryFirstOrDefault("Select * FROM Employees WHERE username = @Username AND password = @Password",
            new { Username = username, Password = Helper.HashToMd5(password) });
    }
}
