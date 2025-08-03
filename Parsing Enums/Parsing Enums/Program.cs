using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {




            List<Employee> listEmp = new List<Employee>()
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 4, FirstName = "Anna", LastName = "Williams" },
                new Employee { Id = 5, FirstName = "Mike", LastName = "Johnson" },
                new Employee { Id = 6, FirstName = "Sara", LastName = "Lee" },
                new Employee { Id = 7, FirstName = "Joe", LastName = "Black" },
                new Employee { Id = 8, FirstName = "Peter", LastName = "Parker" },
                new Employee { Id = 9, FirstName = "Clark", LastName = "Kent" },
                new Employee { Id = 10, FirstName = "Bruce", LastName = "Wayne" }
            };

            List<Employee> joeEmployees = new List<Employee>();
            foreach (Employee employee in listEmp)
            {
                if (employee.FirstName == "Joe") // Check if the FirstName is "Joe"
                {
                    joeEmployees.Add(employee);  // Add to the new list if condition is true
                }
            }

            Console.WriteLine("Employees named 'Joe' (using foreach):");
            foreach (Employee joe in joeEmployees)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            List<Employee> joes2 = listEmp.Where(x => x.FirstName == "Joe").ToList();

            Console.WriteLine("\nEmployees named 'Joe' (using lambda):");
            foreach (Employee joe in joes2)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }


            List<Employee> bigId = listEmp.Where( x => x.Id > 5 ).ToList();


            Console.WriteLine("\nEmployees with Id greater than 5:");
            foreach (Employee employee in bigId)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }



            Console.ReadLine();




            Numbers numbers = new Numbers();
            numbers.Amount = 15;

            Console.WriteLine("Amount is: " + numbers.Amount);




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
