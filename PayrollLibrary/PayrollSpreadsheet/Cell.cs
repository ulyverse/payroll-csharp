using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary.PayrollSpreadsheet
{
    public class Cell
    {

        public int Row { get; set; }
        public int Column { get; set; }
        public string Text { get; set; } = "";
    }
}
