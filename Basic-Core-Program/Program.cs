﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    class LeapYear
    { 
       
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("enter a year");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
                Console.WriteLine("year is a leap year");
            else
                Console.WriteLine("year is not a leap year");
            Console.ReadLine();
        }
    }
}
