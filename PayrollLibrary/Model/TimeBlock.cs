﻿namespace PayrollLibrary.Model
{
    public class TimeBlock
    {
        private TimeOnly _timeIn;
        private TimeOnly _timeOut;

        public TimeBlock(int startingHour = 8, int startingMinutes = 0, int endingHour = -1, int endingMinutes = 0)
        {
            if (endingHour == -1)
                endingHour = startingHour;
            TimeIn = new TimeOnly(startingHour, startingMinutes);
            TimeOut = new TimeOnly(endingHour, endingMinutes);
        }

        public TimeOnly TimeIn
        {
            get { return _timeIn; }
            set
            {
                _timeIn = value;
                if (PropertyChanged != null)
                    PropertyChanged();
            }
        }
        public TimeOnly TimeOut
        {
            get { return _timeOut; }
            set
            {
                _timeOut = value;
                if (PropertyChanged != null)
                    PropertyChanged();
            }
        }


        public event ValueWatcher PropertyChanged;
    }

    public delegate void ValueWatcher();
}
