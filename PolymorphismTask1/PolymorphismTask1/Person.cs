using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTask1
{
    public abstract class Person
    {
        public String firstName {  get; set; } 
        public String lastName {  get; set; }
        // Abstract method SayName() to be implemented by child classes.
        public abstract void SayName();
    }
    
}
    
