using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTask1
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public override void SayName()
        {
            Console.WriteLine("Name : " + firstName + " " + lastName);  
        }
        public void Quit()
        {
            Console.WriteLine(firstName + " its from here " + lastName);
        }
    }
}
