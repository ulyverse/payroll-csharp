using PayrollLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary.Data_Access
{
    public class PayrollEmployeeData : SqliteDataAccess<PayrollEmployee>
    {
        public static List<int> GetAllIDFromPayroll(int payrollId)
        {
            return Query("SELECT ID FROM PayrollEmployees WHERE PayrollID = @PayrollId", new { PayrollId = payrollId }).Select(x => x.ID).ToList();
        }

    }
}
