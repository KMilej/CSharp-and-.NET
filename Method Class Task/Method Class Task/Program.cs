using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maths maths = new Maths();
            maths.Operation(10, 5);   // we call a method on instance maths

            Console.ReadLine(); // keep program on
        }
    }

}
