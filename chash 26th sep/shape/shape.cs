using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape
{
    public abstract class Shape
    {
        public virtual double CalculateArea()
        {
          Console.WriteLine("area is Default SHAPE area");
            return 0;
        }
    }
}
