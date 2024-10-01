using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace shape
{
    internal class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public Rectangle(double length,double breadth) 
        {
            Breadth = breadth;
            Length = length;
        }
        public override double CalculateArea()
        {
            return Breadth * Length;
        }
    }
}