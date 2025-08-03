using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismTask1
{
    class operation : Numbers, Itestinter
    {
        // Implement the 'doMaths' method
        public void doMaths()
        {
            // Access the protected properties from the 'Numbers' class
            int sum = numOne + numTwo;

            // Output the result
            Console.WriteLine("The sum of numOne and numTwo is: " + sum);
        }
    }
}
