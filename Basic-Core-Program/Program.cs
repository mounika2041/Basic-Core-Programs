using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
   public class SwapNumbers
   {
        public int first, second, temp = 0;

        public void SwapTwoNumbers()
        {

            Console.WriteLine("Please enter first number");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping");
            Console.WriteLine("Fitst:{0} second:{1}", first, second);
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine("after swapping");
            Console.WriteLine("Fitst:{0} second:{1}", first, second);
        }

        private static void Main(string[] args)
        {
            SwapNumbers swap = new SwapNumbers();
            swap.SwapTwoNumbers();
            Console.ReadLine();
        }
    }
}
