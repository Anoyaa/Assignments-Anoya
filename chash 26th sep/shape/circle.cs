using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    class Circle: Shape
    {
        double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea() 
        {
            return 22.7 * Radius * Radius;
        }
    }
}
