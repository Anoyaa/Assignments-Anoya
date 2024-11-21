using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chashassignday3
{
    class Employee
    {
        public int id { get; set; }
        public string name { get ; set; }  
        public double salary { get; set; }
        public string emp_type { get; set; }

      
           public void display()
            {
                Console.WriteLine("employee id:" + id);
                Console.WriteLine("employee name:" + name);
                Console.WriteLine("employee type:" + emp_type);
                Console.WriteLine("employee salary" + salary);
            }

        public Employee(int id,string name,double salary,string emp_type)
        {
            this.id = id;
            this.name= name;    
            this.salary = salary;   
            this.emp_type = emp_type;   
        }
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee(1, "aaa", 24000, "permanent");
            Employee emp2 = new Employee(2, "bbb", 34000, "contract");
            Employee emp3 = new Employee(3, "ccc", 35000, "contract");
            Console.WriteLine("enter the employee id,name,employment type, salary:");
            emp1.display();
            emp2.display();
            emp3.display();

            //emp.id = Convert.ToInt32(Console.ReadLine());
            //emp.name = Convert.ToString(Console.ReadLine());
            //emp.emp_type = Convert.ToString(Console.ReadLine());
            //emp.salary = Convert.ToDouble(Console.ReadLine());

        }

    }


}

