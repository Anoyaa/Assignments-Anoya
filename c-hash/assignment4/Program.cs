using System;
class Program
    {
        public static void Main(string[] args)
        {
        int number, reversed_number;
        reversed_number = 0;
        Console.WriteLine("enter the number");
        number=Convert.ToInt32(Console.ReadLine());
        while(number>0)
        {
            reversed_number = (reversed_number*10) + (number % 10);
            number = number / 10;
        }
        Console.WriteLine("the reversed number is " + reversed_number);
        Console.ReadLine();
        }
    }
