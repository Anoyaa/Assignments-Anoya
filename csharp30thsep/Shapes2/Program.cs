using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, b, l, h, bottom, s1, s2, s3;
            Console.WriteLine("enter in order the circle radius");
            r = Convert.ToDouble(Console.ReadLine());
            IShape circle = new Circle2(r);
            Console.WriteLine("area of circle is " + circle.CalculateArea());
            Console.WriteLine("area of circle is " + circle.CalculatePerimeter());

            Console.WriteLine("enter in order the rectangle's Breadth ,then Length");
            b = Convert.ToDouble(Console.ReadLine());
            l = Convert.ToDouble(Console.ReadLine());
            IShape rectangle = new rectangle2(l, b);
            Console.WriteLine("area of rectangle is " + rectangle.CalculateArea());
            Console.WriteLine("area of rectangle is " + rectangle.CalculatePerimeter());

            Console.WriteLine("enter in order the traingle's base length ,then Height,side1,side2,side3");
            bottom = Convert.ToDouble(Console.ReadLine());
            h = Convert.ToDouble(Console.ReadLine());
            s1= Convert.ToDouble(Console.ReadLine());
            s2 = Convert.ToDouble(Console.ReadLine());
            s3 = Convert.ToDouble(Console.ReadLine());
            IShape triangle = new Triangle2(bottom, h, s1, s2, s3);
            Console.WriteLine("area of triangle is" + triangle.CalculateArea());
            Console.WriteLine("area of triangle is" + triangle.CalculatePerimeter());

        }
    }
}
