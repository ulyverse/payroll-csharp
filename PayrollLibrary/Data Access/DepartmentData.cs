using PayrollLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary.Data_Access
{
    public class DepartmentData : SqliteDataAccess<Department>
    {
        public static int DeleteDepartment(int id)
        {
            int affectedRows = Execute("UPDATE Employees SET DepartmentID = NULL WHERE DepartmentID = @DepartmentID", new { DepartmentID = id });

            return affectedRows + Delete(id);
        }
    }
}
