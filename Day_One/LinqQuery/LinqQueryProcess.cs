using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuery
{
    class LinqQueryProcess
    {
        static void Main(string[] args)
        {
            Process[] processes = Process.GetProcesses();

            IEnumerable<Process> query = from p in processes
                                         where p.ProcessName == "notepad"
                                         || p.ProcessName == "devenv"
                                         || p.ProcessName == "chrome"
                                         || p.ProcessName == "iexplore"
                                         orderby p.ProcessName ascending
                                         select p;

            Console.WriteLine("Processes running:\n-----------------");
            foreach (Process p in query)
            {
                Console.WriteLine("{0, -5}{1}", p.Id, p.ProcessName);
            }
            Console.ReadLine();
        }
    }



}
