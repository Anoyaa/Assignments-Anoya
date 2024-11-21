using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    internal class Program
    {
       public static void Main(string[] args)
        {

            double r, b, l, h, bottom;
            Console.WriteLine("enter in order the circle radius");
            r = Convert.ToDouble(Console.ReadLine());
            Shape circle = new Circle(r);
            Console.WriteLine("area of circle is " + circle.CalculateArea());

            Console.WriteLine("enter in order the rectangle's Breadth ,then Length");
            b = Convert.ToDouble(Console.ReadLine());   
            l = Convert.ToDouble(Console.ReadLine());
            Shape rectangle = new Rectangle(l, b);
            Console.WriteLine("area of rectangle is " + rectangle.CalculateArea());

            Console.WriteLine("enter in order the traingle's base length ,then Height");
            bottom = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
            Shape triangle = new Triangle(bottom, h);
            Console.WriteLine("area of triangle is" + triangle.CalculateArea());
           
        }
    }
}
