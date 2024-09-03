using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };

           for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            string[] names = { "Kamil", "Michal", "Edyta" };
            for (int j = 0; j < names.Length ; j++)
            {
                Console.WriteLine(names[j]);
            }
            Console.ReadLine();
        }


        
    }
}
