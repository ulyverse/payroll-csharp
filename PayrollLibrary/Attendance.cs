using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollLibrary
{
    public class Attendance
    {
        public Attendance(DateOnly date)
        {
            Date = date;
        }
        private DateOnly Date;
        public string DateName => $"{Date:MM/dd/yyyy} ({Date.DayOfWeek.ToString().ToUpper().Substring(0, 3)})";
        public TimeSpan Morning { get; set; }
        public TimeSpan Afternoon { get; set; }
        public TimeSpan Overtime { get; set; }
        public bool Enabled { get; set; } = true;

        public override string ToString()
        {
            return $"Date {DateName}\n" +
                $"Morning {Morning}\n" +
                $"Afternoon {Afternoon}\n" +
                $"Overtime {Overtime}\n" +
                $"Enabled {Enabled}";
        }
    }
}
