using System.ComponentModel;

namespace PayrollLibrary
{
    public class Attendance : INotifyPropertyChanged
    {
        public Attendance(DateOnly date)
        {
            Date = date;
            TimeBlocks[0] = new TimeBlock(8, 0);
            TimeBlocks[1] = new TimeBlock(13, 0);
            TimeBlocks[2] = new TimeBlock(19, 0);

            foreach (var block in TimeBlocks)
            {
                block.PropertyChanged += UpdateTotalHoursSpent;
            }
        }

        private DateOnly Date;
        public string DateName => $"{Date:MM/dd/yyyy} ({Date.DayOfWeek.ToString().ToUpper().Substring(0, 3)})";
        public TimeBlock[] TimeBlocks { get; set; } = new TimeBlock[3];
        public bool Enabled { get; set; } = true;
        public TimeSpan TotalHoursSpent { get; set; }
        public TimeSpan NormalWorkingHours { get; set; }
        public TimeSpan OverTime { get; set; }
        public void UpdateTotalHoursSpent()
        {
            NormalWorkingHours = GetNormalWorkingHours();
            OverTime = GetOverTimeHours();
            TotalHoursSpent = NormalWorkingHours + OverTime;
        }

        public TimeSpan GetNormalWorkingHours()
        {
            var normalWorkingHours = new TimeSpan();

            for (var i = 0; i < TimeBlocks.Length - 1; i++)
            {
                var time = TimeBlocks[i];
                if (time.TimeOut < time.TimeIn)
                    continue;
                normalWorkingHours += time.TimeOut - time.TimeIn;
            }
            return normalWorkingHours;
        }
        public TimeSpan GetOverTimeHours()
        {
            var time = TimeBlocks[2];
            if (time.TimeOut.IsBetween(new TimeOnly(18, 00), new TimeOnly(4, 00)))
                return time.TimeOut - time.TimeIn;
            return new TimeSpan();
        }

        public override string ToString()
        {
            return $"Date {DateName}\n" +
                $"Morning Time in: {TimeBlocks[0].TimeIn}, Time out: {TimeBlocks[0].TimeOut}\n" +
                $"Afternoon Time in: {TimeBlocks[1].TimeIn}, Time out: {TimeBlocks[1].TimeOut}\n" +
                $"Overtime Time in: {TimeBlocks[2].TimeIn}, Time out: {TimeBlocks[2].TimeOut}\n" +
                $"Total Hours Spent: {TotalHoursSpent}\n" +
                $"Normal Working Hours: {NormalWorkingHours}\n" +
                $"Over Time: {OverTime}\n" +
                $"Enabled {Enabled}\n";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
