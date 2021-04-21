using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LinqQuery
{
    class LinqtoXml
    {
        class Program
        {
            static void Main(string[] args)
            {
                XmlDocument doc = new XmlDocument();
                XmlElement employees = doc.CreateElement("Employees");
                doc.AppendChild(employees);

                XmlElement employee = doc.CreateElement("Employee");
                employee.InnerText = "Scott";
                XmlAttribute id = doc.CreateAttribute("Id");
                id.InnerText = "101";
                employee.Attributes.Append(id);
                employees.AppendChild(employee);

                employee = doc.CreateElement("Employee");
                employee.InnerText = "Matt";
                id = doc.CreateAttribute("Id");
                id.InnerText = "102";
                employee.Attributes.Append(id);
                employees.AppendChild(employee);

                employee = doc.CreateElement("Employee");
                employee.InnerText = "Ben";
                id = doc.CreateAttribute("Id");
                id.InnerText = "103";
                employee.Attributes.Append(id);
                employees.AppendChild(employee);

                //doc.Save(@"E:\OLT\Advanced .Net\30th april 2013\Employee.xml");
                //Console.WriteLine("Xml file written to disk.");

                doc.Save(Console.Out);
                Console.ReadLine();
            }
        }

    }
}
