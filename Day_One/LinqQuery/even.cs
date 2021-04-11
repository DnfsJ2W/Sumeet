using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuery
{
    class even
    {
        
        static void Main(string[] args)
        {
            int[] arr = { 11, 10, 20, 21, 19, 18, 14, 15 };
            var evens = from even in arr where even % 2 == 0 select even;
            Console.Write("Evens: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (int n in evens)
            {
                Console.Write(" " + n);
            }
            Console.ReadLine();

        }
    }
}

