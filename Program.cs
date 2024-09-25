using System;

    class Sumofnum
    {
        public static void Main(string[] args)
        {
            int a,c;
            int b;
            Console.WriteLine("enter the 1st and 2nd number");
            a= Convert.ToInt32(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("the sum is" + c) ;
        //Console.ReadLine();

        }
    }