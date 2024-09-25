using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace assignment12
{
    class Program
    {
        public static void Main(string[] args)
        {
            char charactervalue;
           label:
            Console.WriteLine("enter the character value");
            charactervalue = Convert.ToChar(Console.ReadLine());
            if (charactervalue == 'c')
            {
                Console.WriteLine("cricket");
            }
            else if (charactervalue =='f')
            {
                Console.WriteLine("football");
            }
            else if (charactervalue == 'h')
            {
                Console.WriteLine("hockey");
            }
            else if (charactervalue == 't')
            {
                Console.WriteLine("tennis");
            }
            else if (charactervalue == 'b')
            {
                Console.WriteLine("badminton");
            }
            else
            {
                Console.WriteLine("Invalid input,please try again!!");
                goto label;
            }
        }
    }
}
