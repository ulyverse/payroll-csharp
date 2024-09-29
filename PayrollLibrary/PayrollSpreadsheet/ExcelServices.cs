using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary.PayrollSpreadsheet
{
    public class ExcelServices
    {
        private Application app;
        private Workbooks workbooks;
        private Workbook workbook;
        private Worksheet worksheet;
        private Worksheet template;
        private Microsoft.Office.Interop.Excel.Range templateRange;
        private Microsoft.Office.Interop.Excel.Range destinationRange;
        public ExcelServices(string templatePath)
        {
            app = new Application();
            app.Visible = true;
            workbooks = app.Workbooks;
            workbook = workbooks.Add(templatePath);
            template = workbook.Sheets[1];
            worksheet = workbook.Sheets[2];
        }

        public void WriteCell(Cell cell)
        {
            WriteCell(cell.Row, cell.Column, cell.Text);
        }

        public void WriteCell(int row, int col, string text)
        {
            template.Cells[row, col].Value = text;
        }
        public void SaveAs(string path)
        {
            app.DisplayAlerts = false;
            template.Delete();
            app.DisplayAlerts = true;

            worksheet.SaveAs2(path);

        }

        public void SetTemplateRange(string sourceRange)
        {
            templateRange = template.Range[sourceRange];
        }

        public void CopyPasteRange(string destinationCell)
        {
            destinationRange = worksheet.Range[destinationCell];
            templateRange.Copy(destinationRange);
        }


        public void Dispose()
        {
            ReleaseComObject(destinationRange);
            ReleaseComObject(templateRange);
            ReleaseComObject(template);
            ReleaseComObject(worksheet);
            workbook.Close(false);
            ReleaseComObject(workbook);
            ReleaseComObject(workbooks);
            app.Quit();
            ReleaseComObject(app);

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ReleaseComObject(object? o)
        {
            try
            {
                while (Marshal.ReleaseComObject(o) != 0) ;
            }
            finally
            {
                Console.WriteLine("release!");
                o = null;
            }
        }
    }
}
