using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
   public class QuotientandRemainder
   {
        static void Main(string[] args)
        {
            int r, q, dividend,divisor;
            Console.WriteLine("enter divident number");
            dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter divisor  number");
            divisor = Convert.ToInt32(Console.ReadLine());
            q = dividend / divisor;
            r = dividend % divisor;
            Console.WriteLine("quotient is:"+q);
            Console.WriteLine("remainder is:"+r);
            Console.ReadLine();
        }
    }
}
