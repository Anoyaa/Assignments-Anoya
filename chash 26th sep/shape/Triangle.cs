using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Triangle:Shape
    {
        double Bottom { get; set; } 
        public double Height { get; set; } 
        public Triangle(double bottom, double height)
        {
            Bottom = bottom;
            Height = height;
        }
        public override double CalculateArea()
        {
           return 0.5*Bottom*Height;
        }

    }
}
