using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeAndTimePeriodLib;
using static System.IO.IOException;
namespace TimeAndTimePeriodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //var t = new Time(seconds:49, m:43, hours: 7);
            var t1 = new Time(5, 7, 18);
            Console.WriteLine(t1);

            string s = "2";
            var t2 = new Time(7, 9, 7);
            Console.WriteLine(t2);
            
            TimePeriod t3 = new TimePeriod( t1, t2);
            
            Console.WriteLine(t3);
            Console.ReadKey();
        }
    }
}
