using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee2
{
    public class Employee2
    {
        public static int eid = 1000;
        public static int employeeCount = 0;
        public static String Id { get; private set; }
        public static string Name { get; set; }
        public static double Salary { get; set; }
       public string emp_type = "permanent";
       /* public string emp_type 
        { get { return emp_type; }
            set { emp_type = value; }
        }*/
        
        public Employee2(int id)
        {
            Id = "emp" + eid.ToString() ;
            eid++;
            employeeCount++;
        }
        public Employee2(int id,string name):this(id)
        {
            Name = name;
        }
        public Employee2(int id,string name,double salary):this(id,name)
        {
            Salary = salary;
        }

        public void Display()
        {
            Console.WriteLine( $"id: {Id} Name:{Name}  employement type:{emp_type} salary:{Salary}");
        }

        public void DisplayEmployeeCount()
        {
            Console.WriteLine( $"count of employee is{employeeCount}");
        }

    }
}
