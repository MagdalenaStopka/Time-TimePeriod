using System;
using System.Collections.Generic;
using System.Text;

namespace TimeAndTimePeriodLib
{
    public struct TimePeriod
    {
        readonly private long secondsTimePeriod;
        public long SecondsTimePeriod => secondsTimePeriod;
        public int Hours => (Int32)(secondsTimePeriod / 3600);
        public int Minutes => (Int32)((secondsTimePeriod % 3600) / 60);
        public int Seconds => (Int32)((secondsTimePeriod % 3600) % 60);


        public TimePeriod(int hours, int minutes = 0, int seconds = 0)
        {
            secondsTimePeriod = (hours * 3600 + minutes * 60 + seconds);
        }

        public TimePeriod( Time t1,  Time t2)
        {
                secondsTimePeriod = (t1.Hours - t2.Hours) * 3600 + (t1.Minutes - t2.Minutes) * 60 + (t1.Seconds - t2.Seconds);       
        }

        public override string ToString()
        {
            return $"{String.Format("{0:0000}", Hours)}:{String.Format("{0:00}", Minutes)}:{String.Format("{0:00}", Seconds)}";
        }
    }
}

    
