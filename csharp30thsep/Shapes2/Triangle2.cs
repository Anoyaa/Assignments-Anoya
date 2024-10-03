using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Shapes2
{
    public class Triangle2:IShape
    {
            double bottom { get; set; }
            double height { get; set; }
            double side1 { get; set; }  
            double side2 { get; set; }  
            double side3 { get; set; }  
            public Triangle2(double b, double h,double s1,double s2,double s3)
            {
                height = h;
                bottom = b;
                side1 = s1;
                side2 = s2; 
                side3 = s3; 

            }
            public double CalculateArea()
            {
                return 0.5*bottom* height;
            }
            
            public double CalculatePerimeter()
            {
            return side1+side2+side3;
            }
        }
}
