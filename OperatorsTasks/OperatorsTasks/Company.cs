using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsTasks
{
    internal class Company
    {
        public List<Employee> Employees { get; set; }

        public static Company operator +(Company company, Employee employee) // in operator method we should use static, company is a returned type by this method, and after add we retrun company 
        {
            company.Employees.Add(employee);
            return company;
        }
        public static Company operator -(Company company, Employee employee)
        {
            company.Employees.Remove(employee);
            return company;
        }

    }
}
