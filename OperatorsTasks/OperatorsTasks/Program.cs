using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();          // we make new object of type Company
            company.Employees = new List<Employee>();  // we make a inisialize a list of employees like a new empty list.

            Employee employee = new Employee();  // we make new employee
            employee.FirstName = "KAmil";    // we set up him a name

            company = company + employee;   //we add this worker to employee list and we use overloaded operators

            Console.WriteLine("List of Employteees: " + company.Employees.Count); // we see how many workers are in list 


            if (company.Employees.Count > 0) // if workers is more then 0 then show this value in index [0]
            {
                Employee firstEmployee = company.Employees[0]; // we get from list 1 worker and we show 1st employee from list
                Console.WriteLine("First Person from list : " + firstEmployee.FirstName);
            }
            else
            {
                Console.WriteLine("List of Employees are empty."); // if list is empty thne we say it 
            }

                company = company - employee;       // - 1 employee and we use - overload operator

                Console.WriteLine("List of Employteees: " + company.Employees.Count);  // show how many employee is inside list
                Console.ReadLine();
        }
    }
}
