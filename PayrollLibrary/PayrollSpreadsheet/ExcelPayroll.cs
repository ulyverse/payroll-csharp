using PayrollLibrary.Model;
using PayrollLibrary.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary.PayrollSpreadsheet
{
    public class ExcelPayroll
    {
        private ExcelServices excel;
        private ExcelPayrollTemplate template;
        private string folderDirectory = string.Empty;

        public ExcelPayroll(string templatePath, string jsonPath)
        {
            excel = new ExcelServices(templatePath);
            excel.SetTemplateRange("A1:E29");
            template = ExcelPayrollTemplateBuilder.CreatePayrollTemplate(jsonPath);
        }
        public void CreateFolder(string folderName)
        {
            var curDirectory = Directory.GetCurrentDirectory();
            string path = Path.Combine(curDirectory, @$"Payroll\{folderName}");
            folderDirectory = path;
            try
            {
                DirectoryInfo result = Directory.CreateDirectory(path);
                Console.WriteLine($"Folder Created! {result.FullName}");
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }
        public void CreatePayroll(string fileName)
        {
            string path = Path.Combine(folderDirectory, $"{fileName} payroll");
            excel.SaveAs(path);
        }

        public void CopyPasteTemplate(string destinationCell)
        {
            excel.CopyPasteRange(destinationCell);
        }

        public void Dispose()
        {
            excel.Dispose();
        }

        public void FillWorksheet(Payroll payroll, PayrollEmployeeDisplay payrollEmployeeDisplay)
        {
            template.DateRange.Text = $"Pay slip for {payroll.StartDate:MMMM dd} - {payroll.EndDate:MMMM dd yyyy}";
            template.Date.Text = $"MONTH OF {payroll.StartDate.ToString("MMMM").ToUpper()}";

            template.Name.Text = payrollEmployeeDisplay.Name;
            template.Department.Text = payrollEmployeeDisplay.Department;

            template.NormalHours.Text = payrollEmployeeDisplay.NormalHours.ToString("F");
            template.Overtime.Text = payrollEmployeeDisplay.Overtime.ToString("F");
            template.TotalHours.Text = payrollEmployeeDisplay.GetTotalHours().ToString("F");
            template.Rate.Text = payrollEmployeeDisplay.Rate.ToString("N2");

            template.SSS.Text = payrollEmployeeDisplay.SSS.ToString("N2");
            template.PagIbig.Text = payrollEmployeeDisplay.PagIbig.ToString("N2");
            template.PhilHealth.Text = payrollEmployeeDisplay.PhilHealth.ToString("N2");
            template.CashAdvanceAmountToPay.Text = payrollEmployeeDisplay.CashAdvanceAmountToPay.ToString("N2");
            template.Snack.Text = payrollEmployeeDisplay.Snack.ToString("N2");

            template.GrossPay.Text = payrollEmployeeDisplay.GrossPay.ToString("N2");
            template.TotalDeductions.Text = payrollEmployeeDisplay.TotalDeductions.ToString("N2");
            template.NetPay.Text = payrollEmployeeDisplay.NetPay.ToString("N2");

            template.PreviousCashAdvance.Text = payrollEmployeeDisplay.PreviousCashAdvance.ToString("N2");
            template.NextCashAdvance.Text = payrollEmployeeDisplay.NextCashAdvance.ToString("N2");


            foreach (PropertyInfo property in template.GetType().GetProperties())
            {
                if (property.GetValue(template) is Cell)
                {
                    Cell currentCell = (Cell)property.GetValue(template);
                    excel.WriteCell(currentCell);
                }
            }
        }
    }
}
