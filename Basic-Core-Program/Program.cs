using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
   class Factors
   {
      
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("enter a integer number");
            n = int.Parse(Console.ReadLine());
            while(n!=1)
                for(i=2;i<=n;i++)
                {
                    if(n%i==0)
                    {
                        Console.WriteLine(i + "is a factor of" + n);
                        n = n / i;
                        break;
                    }
                }
            Console.ReadLine();
        }
    }
}
