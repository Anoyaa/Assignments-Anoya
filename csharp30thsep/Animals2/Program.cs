using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,number;
            
            do
            {
                Console.WriteLine( "enter numbers to know sound of corresponding animals as 1:dog, 2:cat ,3:bird");
                number=Convert.ToInt16(Console.ReadLine());
                if(number==1)
                {
                    Animals2 dog = new Dogs2();
                    dog.MakeSound();
                }
                else if(number==2)
                {
                    Animals2 cat = new Cats2();
                    cat.MakeSound();
                }
                else if(number==3)
                { 
                    Animals2 bird = new Birds2();
                    bird.MakeSound();

                }
                else 
                {
                    Console.WriteLine("input again"); 
                }
                Console.WriteLine("do u want to know sounds of other animals too?");
                i=Convert.ToInt16(Console.ReadLine());
            } while (i == 1) ;
        }
    }
}
