using System;

namespace Shapes2
{
    public class Circle2:IShape
    {
        double radius { get; set; }
        public Circle2(double r)
        {
            radius = r;   
        }

        public double CalculateArea() 
        {
            return 22.7 * radius * radius;
        }

        public double CalculatePerimeter()
        {
            return 2 * 22.7 * radius;
        }
    }
}
