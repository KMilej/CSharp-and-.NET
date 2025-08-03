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

            // Create an instance of 'operation' and initialize numOne and numTwo
            operation operationn = new operation() { numOne = 1, numTwo = 2 };

            // Use polymorphism: Assign the 'operationn' object to an 'Itestinter' interface reference
            Itestinter test = operationn;

            // Call the doMaths method from the interface reference
            test.doMaths();

            // Wait for user input to keep the console open
            Console.ReadLine();
        }
    }
}
