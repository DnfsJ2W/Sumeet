using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuery
{
    class Join
    {
        class Employee
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public decimal Salary { get; set; }
            public string Department { get; set; }
        }
        class Department
        {
            public int DeptId { get; set; }
            public string DeptName { get; set; }
            public string Location { get; set; }
        }

        static void Main()
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee(){EmpId=101,EmpName="Scott",Salary=10000,Department="HR"},
                new Employee(){EmpId=102,EmpName="Shoaib",Salary=9000,Department="IT"},
                new Employee(){EmpId=103,EmpName="Sachin",Salary=11000,Department="Sales"},
                new Employee(){EmpId=104,EmpName="Rahul",Salary=8000,Department="IT"},
                new Employee(){EmpId=105,EmpName="Ilyas",Salary=12000,Department="HR"},
                new Employee(){EmpId=106,EmpName="Kashif",Salary=12000,Department="Finance"}
            };
            List<Department> deptList = new List<Department>()
            {
                new Department(){DeptId=1,DeptName="HR",Location="Delhi"},
                new Department(){DeptId=2,DeptName="Sales",Location="Mumbai"},
                new Department(){DeptId=3,DeptName="IT",Location="Hyderabad"},
            };

            var joinquery = from emp in empList
                            join dept in deptList on
                            emp.Department equals dept.DeptName
                            select new
                            {
                                EName = emp.EmpName,
                                ESalary = emp.Salary,
                                EDept = dept.DeptName,
                                ELocation = dept.Location
                            };
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Employee join Department:\n----------------------------");
            foreach (var emp in joinquery)
            {
                Console.WriteLine("{0, -7}{1, -7}{2, -7}{3, -12}", emp.EName, emp.ESalary, emp.EDept, emp.ELocation);
            }
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
