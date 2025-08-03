using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodObjectTask1
{
    internal class Person
    {
        public string FirstName {get; set;}
        public string LastName { get; set; }

        public void sayName()
        {
            Console.WriteLine("name: " + this.FirstName + " " + this.LastName);
        }

    }
}
