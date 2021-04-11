using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuery
{

    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }
    class arraysearch
    {

        static void Main(string[] args)
        {
            Employee[] empList = new Employee[]
            {
                new Employee(){EmpId=101,EmpName="Scott",Salary=10000,Department="HR"},
                new Employee(){EmpId=102,EmpName="Shoaib",Salary=9000,Department="IT"},
                new Employee(){EmpId=103,EmpName="Sachin",Salary=11000,Department="Sales"},
                new Employee(){EmpId=104,EmpName="Rahul",Salary=8000,Department="IT"},
                new Employee(){EmpId=105,EmpName="Ilyas",Salary=12000,Department="HR"},
                new Employee(){EmpId=106,EmpName="Kashif",Salary=12000,Department="Finance"}
            };
            Employee rahul = Array.Find(empList, FindEmpPredicate);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("EmpId: " + rahul.EmpId);
            Console.WriteLine("EmpName: " + rahul.EmpName);
            Console.WriteLine("Salary: " + rahul.Salary);
            Console.WriteLine("Department: " + rahul.Department);
            Employee sachin = Array.Find(empList, delegate (Employee emp)
             {
                 return emp.EmpName == "Sachin";
             });
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("EmpId: " + sachin.EmpId);
            Console.WriteLine("EmpName: " + sachin.EmpName);
            Console.WriteLine("Salary: " + sachin.Salary);
            Console.WriteLine("Department: " + sachin.Department);
    
            Employee ilyas = Array.Find(empList, emp => emp.EmpName == "Ilyas");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("EmpId: " + ilyas.EmpId);
            Console.WriteLine("EmpName: " + ilyas.EmpName);
            Console.WriteLine("Salary: " + ilyas.Salary);
            Console.WriteLine("Department: " + ilyas.Department);
       
            Employee kashif = (from emp in empList where emp.EmpName == "Kashif" select emp).Single();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("EmpId: " + kashif.EmpId);
            Console.WriteLine("EmpName: " + kashif.EmpName);
            Console.WriteLine("Salary: " + kashif.Salary);
            Console.WriteLine("Department: " + kashif.Department);
            Console.ReadLine();

        }

        private static bool FindEmpPredicate(Employee emp)
        {
            return emp.EmpName == "Rahul";
        }
    }
}

