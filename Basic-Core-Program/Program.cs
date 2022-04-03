using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
   class VowelorConsonant
   {
        static void Main(string[] args)
        {
            Char ch;
            Console.WriteLine("enter a character");
            ch = Convert.ToChar(Console.ReadLine());
            switch(ch)
            {
                case 'A':
                case 'a':
                case 'E':
                case 'e':
                case 'I':
                case 'i':
                case 'O':
                case 'o':
                case 'U':
                case 'u':
                    Console.WriteLine("{0} character is a vowel", ch);
                    break;
                default:
                    Console.WriteLine("{0} character is a consonant", ch);
                    break;
            }
            Console.ReadLine();
        }
    }
}
