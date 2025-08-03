using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person
    {
        private String name {  get; set; }
        private String Surname { get; set; }
        public abstract void SayName();
    }

}
