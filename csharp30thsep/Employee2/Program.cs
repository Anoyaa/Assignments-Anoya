using System;


namespace Employee2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int i;
            double salary;
            string name, emp_type;
            
                Console.WriteLine("enter the employee name,emp_type(permanent/contract),salary");
                name=Console.ReadLine();
                emp_type = Console.ReadLine();
                salary = Convert.ToDouble(Console.ReadLine());
                 Employee2 emp1 = new Employee2(1,name, salary);
                emp1.Display();
                emp1.DisplayEmployeeCount();

            Console.WriteLine("enter the employee name,emp_type(permanent/contract),salary");
            name = Console.ReadLine();
            emp_type = Console.ReadLine();
            salary = Convert.ToDouble(Console.ReadLine());
            Employee2 emp2 = new Employee2(2, name, salary);
            emp2.Display();
            emp2.DisplayEmployeeCount();

            Console.WriteLine("enter the employee name,emp_type(permanent/contract),salary");
            name = Console.ReadLine();
            emp_type = Console.ReadLine();
            salary = Convert.ToDouble(Console.ReadLine());
            Employee2 emp3 = new Employee2(3, name, salary);
            emp3.Display();
            emp3.DisplayEmployeeCount();
            //Console.WriteLine("do you want to enter more employee's details?");
            //i=Convert.ToInt16(Console.ReadLine());

        }
    }
    
}
