using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double number1,number2,result;
            int operation;
            calculator c = new calculator();
         again:
            Console.WriteLine( "enter the 2 numbers on which the operation is to be done");
            number1=Convert.ToDouble(Console.ReadLine());
            number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter: 1-add, 2-sub,3-multiply, 4- division ");
            operation= Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    result = c.add(number1, number2);
                    break;
                case 2:
                    result=c.sub(number1, number2);
                    break;
                case 3:
                    result = c.mult(number1, number2);
                    break;
                case 4:
                    result = c.div(number1, number2);
                    break;
                default:
                    Console.WriteLine("operation invalid, try again");
                    goto again;
            }

           
            Console.WriteLine("result is"+result);

        }
    }
}
