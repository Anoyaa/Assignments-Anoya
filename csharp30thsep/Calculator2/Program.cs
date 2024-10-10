using System;
using Math.operations;

namespace CalculatorNew
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Arithmeticoperations a = new Arithmeticoperations();
            Relationaloperations r = new Relationaloperations();
            double addres = a.add(3, 7);
            double subres = a.subtract(16, 7);
            bool booleres = r.Equal(4, 6);
            bool greatres = r.GreaterThan(5, 8);
            Console.WriteLine($"addition result is {addres}");
            Console.WriteLine($"subtract result is {subres}");
            Console.WriteLine($"equals result is {booleres}");
            Console.WriteLine($"greaterthan result is {greatres}");

        }
    }
}
