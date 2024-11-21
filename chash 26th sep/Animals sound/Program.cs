using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog("dog");
            Cat cat = new Cat("cat");
            Bird bird = new Bird("bird");
            Console.WriteLine( bird.Sound());
            Console.WriteLine( dog.Sound());
            Console.WriteLine( cat.Sound());
        }  
    }
}
