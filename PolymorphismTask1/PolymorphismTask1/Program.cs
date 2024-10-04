using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sam", lastName = "Snow" };
            employee.SayName();

            IQuittable quittableEmployee = employee;  // Polymorphism: Assign the Employee object to an IQuittable interface reference

            quittableEmployee.Quit();// Call the Quit() method using the IQuittable reference
            Console.ReadLine();
        }
    }
}
