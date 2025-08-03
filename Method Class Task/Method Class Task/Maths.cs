using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_Task
{
    internal class Maths
    {
        public void Operation(int numOne, int numTwo) // create a method
        {
            int sumadd = numOne + numTwo;       // we do operations
            int sumsub = numOne - numTwo;
            int summulti = numOne * numTwo;
            int sumdiv = numOne / numTwo;

            Console.WriteLine("The result of + is " + sumadd);  // we display results
            Console.WriteLine("The result of - is " + sumsub);
            Console.WriteLine("The result of * is " + summulti);
            Console.WriteLine("The result of / is " + sumdiv);

            Console.WriteLine("second number is: " + numTwo);  // we display 2nd number value
        }
    }
}
