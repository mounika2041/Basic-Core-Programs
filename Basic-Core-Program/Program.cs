using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
   class HarmonicSeries
   {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Power of 2^" + num + " is: " + (Math.Pow(2, num)));
           Console.WriteLine("Printing all till Power Value " + num);

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Power of 2^" + i + " is: " + (Math.Pow(2, i)));
            }
            Console.ReadLine();
        }

    }
}
