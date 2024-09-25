using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace assignment9
{
    class Program
    {
        public static void Main(string[] args)
        {
            int number, first = 0,second=1,fibonacci=0;
            Console.WriteLine("fibonacci numbers till 50");
            Console.WriteLine(first);
            Console.WriteLine(second);
            fibonacci = first + second;
            Console.WriteLine(fibonacci);
            for(number=1;number < 10;number++)
            { 
                first = second;
                second = fibonacci;
                fibonacci = first + second;
                Console.WriteLine(fibonacci);
            }
            Console.ReadLine();
        }
    }
}
