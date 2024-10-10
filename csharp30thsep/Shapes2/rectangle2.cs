using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes2
{
    internal class rectangle2:IShape
    {
       double length { get; set; }  
        double breadth { get; set; }
        public rectangle2(double l, double b)
        {
            length = l;
            breadth = b;
        }
        public double CalculateArea()
        {
            return length * breadth;
        }

        public double CalculatePerimeter()
        {
            return 2*(length + breadth);
        }
    }
}
