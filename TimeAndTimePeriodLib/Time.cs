using System;

namespace TimeAndTimePeriodLib
{
    public struct Time
    {
       public byte Hours { get; private set; }
       public byte Minutes { get; private set; }
       public byte Seconds { get; private set; }

        public Time(byte hours, byte minutes=0, byte seconds=0) // opcjonalnosc mozna ustawiac tylko od tylu
        {
            Hours = hours; Minutes = minutes; Seconds = seconds;
            Verify();
        }

        public Time (string napis)
        {
            // nie ma sensu, bo i tak zostanie zgłoszony ten wyjątek
            //if (napis is null)
            // throw new NullReferenceException(); 

            if (napis is null)
                throw new ArgumentNullException();
            string[] tokens = napis.Split(':');
            switch( tokens.Length)
            {
                case 1: // nie ma dwukropka
                    Hours = Convert.ToByte(tokens[0]);
                    Minutes = 0;
                    Seconds = 0;
                    break;
                case 2: // jeden dwukropek np 2:15
                    Hours = Convert.ToByte(tokens[0]);
                    Minutes = Convert.ToByte(tokens[1]);
                    Seconds = 0;
                    break;
                case 3: // dwa dwukropki 2:15:34
                    Hours = Convert.ToByte(tokens[0]);
                    Minutes = Convert.ToByte(tokens[1]);
                    Seconds = Convert.ToByte(tokens[2]);
                    break;
                default:   // więcej dwukropków
                    throw new FormatException("");

            }
            Verify();

            
        } // Time(string)

        private void Verify()
        {
            if (Hours > 23 || Minutes > 59 || Seconds > 59)
                throw new ArgumentException("nie właściwe dane");
        }

        public override string ToString()
        {
            return $"{Hours:D2}:{Minutes:D2}:{Seconds:D2}";
        }
    }
}
