using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool invalid = false;
            while (!invalid)
            {
                try
                {
                    Console.WriteLine("Enter the current day of the week");
                    string dayinput = Console.ReadLine();

                    TestEnum.DaysOfTheWeek day = (TestEnum.DaysOfTheWeek)Enum.Parse(typeof(TestEnum.DaysOfTheWeek), dayinput, true);

                    Console.WriteLine("Have a nice " + day);
                    Console.ReadLine();
                    invalid = true;
                }
                catch (ArgumentException ex) 
                {
                    Console.WriteLine("please enter an actual dayof the week");
                }
            }

        }
    }
}
