using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuery
{
    class smallandbignumber
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var largernumber = from n in arr where n > 5 select n;
            Console.Write("Number greater than 5: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (int n in largernumber)
            {
                Console.Write(" " + n);
            }
            Console.ResetColor();
            var smallernumber = from n in arr where n < 5 select n;
            Console.WriteLine();
            Console.Write("Number smaller than 5: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            foreach (int n in smallernumber)
            {
                Console.Write(" " + n);
            }
            Console.ReadLine();

        }
    }
}
