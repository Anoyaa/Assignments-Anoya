using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment11
{
    class Program
    {
        public static void Main(string[] args)
        {
            int amount;
            float tax=0;
            Console.WriteLine("enter the amount of whose tax is to be found");
            amount=Convert.ToInt32(Console.ReadLine());
            if(amount<10000)
            {
                tax = 5;
            }
            else if(amount>=10000 && amount<15000)
            {
                tax = 7.5f;
            }
            else if(amount>=15000 && amount<20000)
            {
                tax = 10;
            }
            else if(amount>=20000 && amount<=25000)
            {
                tax = 12.5f;
            }
            else if(amount>25000)
            {
                tax = 15;
            }
            Console.WriteLine("tax for "+ amount+" is "+tax+"%");
        }
    }
}
