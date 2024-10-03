using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment10
{
    class Program10
    {
        public static void Main(string[] args)
        {
            int number, palindrome,originalnumber;
            Console.WriteLine("enter the number to do a palindrome check");
            number=Convert.ToInt32(Console.ReadLine());
           originalnumber = number;
            for(palindrome = 0;number > 0; )
            {
               palindrome = (palindrome * 10) + (number % 10);
                number = number / 10;
            }
            Console.WriteLine(palindrome);
            if (originalnumber==palindrome)
            {
                Console.WriteLine("is a palindrome");
            }
            else
            {
                Console.WriteLine("is not a palindrome");
            }
        }
    }
}
