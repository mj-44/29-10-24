using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs_life_problem
{
    internal class Program
    {
        
        static void DogAge(double age)
        {
            double dogyears = 0.0;
            if (age <= 2)
            {
                dogyears = age * 12;
            }
            else
            {
                dogyears = 24 + (age - 2) * 6;
            }
            Console.WriteLine("The age of your dog in dog years {0}", dogyears);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {

            DogAge(6.5);

        }
    }
}
