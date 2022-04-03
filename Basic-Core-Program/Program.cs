using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
   class EvenOROdd
   {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("{0} number is even number",n);
            else
                Console.WriteLine("{0} number is odd number",n);
               Console.ReadLine();
        }
    }
}
