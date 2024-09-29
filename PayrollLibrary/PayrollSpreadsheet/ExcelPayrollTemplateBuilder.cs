using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary.PayrollSpreadsheet
{
    public class ExcelPayrollTemplateBuilder
    {
        public static ExcelPayrollTemplate CreatePayrollTemplate(string jsonPath)
        {
            using (StreamReader sr = new StreamReader(jsonPath))
            {
                string json = sr.ReadToEnd();
                ExcelPayrollTemplate template = JsonConvert.DeserializeObject<ExcelPayrollTemplate>(json);
                return template;
            }
        }
    }
}
