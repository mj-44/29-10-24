using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hours_in_a_day_problem
{
    internal class Program
    {

        static void HoursInADay(int hours)
        {
            double days = 0;
            days = (hours / 24);
            Console.WriteLine("There are {0: 0} days in {1} hours", days, hours);
            Console.ReadLine();
        }
        
        static void Main(string[] args)
        {

            HoursInADay(48);
            HoursInADay(36);

        }
    }
}
