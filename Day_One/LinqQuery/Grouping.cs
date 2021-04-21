using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuery
{
    class Grouping
    {
        class Employee
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public decimal Salary { get; set; }
            public string Department { get; set; }
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
                new Employee(){EmpId=106,EmpName="Kashif",Salary=12000,Department="Fin"},
                new Employee(){EmpId=107,EmpName="Anna",Salary=14000,Department="IT"},
                new Employee(){EmpId=108,EmpName="ankur",Salary=15000,Department="Sales"}
            };

                // into operator
                var query = from emp in empList
                            where emp.EmpName.StartsWith("S")
                            select emp into e
                            where e.EmpName.Length > 5
                            select e;

                foreach (var e in query)
                {
                    Console.WriteLine("{0, -7}", e.EmpName);
                }

                /////////////////
                var groupquery = from emp in empList
                                 group emp by emp.Department
                                     into empgroup
                                 select empgroup;

                Console.ForegroundColor = ConsoleColor.Magenta;
                foreach (var emp in groupquery)
                {
                    Console.WriteLine("-----\n" + emp.Key + "\n-----");
                    foreach (var e in emp)
                    {
                        Console.WriteLine("{0, -7}{1, -7}", e.EmpName, e.Department);
                    }
                }

                Console.ReadLine();
            }
        }



    }

