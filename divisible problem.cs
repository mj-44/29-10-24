using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible_problem
{
    internal class Program
    {
        
        static void isDivisible (double X, double Y)
        {
            bool is_div = false;
            if (Y == 0)
            {
                is_div = false;
            }

            else if (X % Y == 0)
            {
                is_div = true;
            }
            else
            {
                is_div = false;
            }
            if (is_div == false)
            {
                Console.WriteLine("Not divisible");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Divisible");
                Console.ReadLine();
            }
        }   
        
        static void Main(string[] args)
        {

            isDivisible(8, 2);
            isDivisible(10, 3);
            isDivisible(10, 0);

        }
    }
}
