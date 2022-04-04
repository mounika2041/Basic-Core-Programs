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
            int  num;
            Console.WriteLine("The harmonic series is 1/1+1/2+1/3+1/4+.......+1/n");
            Console.WriteLine("================================");
            Console.WriteLine("enter the value of N");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i<=num)

                    Console.WriteLine("1/{0} +", i);
                
            }
            Console.ReadLine();
        }

    }
}
