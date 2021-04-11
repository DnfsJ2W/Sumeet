using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuery
{
    class DefferedQueryExecution
    {
        static void Main(string[] args)
        {
            string[] trainee = new string[4] { "scott", "lauren", "ben", "Mac" };
            var names = from t in trainee
                        select t;
            string[] _names = names.ToArray();
            Console.WriteLine("Trainee list - 1: ");
            foreach (string t in _names)
            {
                Console.WriteLine(" " + t);
            }



            _names[1] = "Sumeet";
            _names[2] = "Bhati";
            Console.WriteLine("Trainee list - 2: ");
            foreach (string t in _names)
            {
                Console.WriteLine(" " + t);
            }

            Console.ReadLine();




        }
    }
}
