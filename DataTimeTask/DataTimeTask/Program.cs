using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTimeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print the currnt data and time to the console
            Console.WriteLine("the current time is: " + DateTime.Now);
            // ask the user for a number
            Console.WriteLine("\nEnter a number to see what the time will be in the many hours: ");
            float answer = float.Parse(Console.ReadLine());
            //print what time it will be in the amount of hours the user input
            Console.WriteLine("{0} + {1} hours(s) = {2}", DateTime.Now, answer, DateTime.Now.AddHours(answer));

            Console.ReadLine(); 
        }
    }
}
