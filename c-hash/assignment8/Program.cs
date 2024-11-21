using System;
using System.Globalization;

class Program
{
    public static void Main(string[] args)
    {
        int number,i, count;
        Console.WriteLine("Prime numbers below 100 are:");

        for (number =2; number <100; number++)
        {
            count = 0;
            for(i = 2;i<number/2;i++)
            {
                if (number % i == 0)
                {
                    count = count+1;
                }
            }
            if (count == 0)
            {  Console.WriteLine(number);
            } 
        }
        //Console.ReadLine();
    }
}
