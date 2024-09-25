using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

class Program
{
    public static void Main(string[] args)
    {
        int number, digit=0, sum = 0;
        Console.WriteLine("enter the number whose sum of digits is to be found");
        number=Convert.ToInt32(Console.ReadLine());
        while(number>0)
        {
            digit = number % 10;
            sum= sum+digit;
            number = number / 10;
        }
        Console.WriteLine("the sume of digits of a number is"+sum);
        Console.ReadLine();
    }
}