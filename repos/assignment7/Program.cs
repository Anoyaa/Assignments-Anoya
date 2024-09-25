using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
    class Program
    {
        public static void Main(string[] args)
        {
        int number,i=2,count=0;
        Console.WriteLine( "enter the number to be checked whether its prime or not");
        number = Convert.ToInt32(Console.ReadLine());
        while(i<number)
        {
            if(number%i==0)
            {
                count = 1;
            }
            i++;
        }
        if(count==1)
        {
            Console.WriteLine("number is not a prime number");
        }    
        else
        {
            Console.WriteLine("is a prime number");
        }
        Console.ReadLine();
        }
    }

