using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Program3
{
    public static void Main(string[] args)
    {
        int number1, number2, number3;
        Console.WriteLine("enter the 3 numbers");
        number1=Convert.ToInt16(Console.ReadLine());
        number2 =Convert.ToInt16(Console.ReadLine());
        number3 =Convert.ToInt16(Console.ReadLine());
        if (number1> number2 && number1 > number3)
        {
            Console.WriteLine("greatest is" + number1);
        }
        else if (number2 >number1 && number2 > number3)
        { Console.WriteLine("greatest is " + number2);
        }
        else
        {
            Console.WriteLine("greatest is" + number3);
        }
        Console.ReadLine();
    }
}
            //  {
            //       Console.WriteLine("greatest is" + a) ;
            //  }
            //   else if(b>c)
            //  {
            //       Console.WriteLine("greatest is"+b);
            //   }
            //  }
            //  else if(a<b)
     
