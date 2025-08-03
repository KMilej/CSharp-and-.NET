using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fewArraysTasks
{
    class NumberOperations
    {
        // Step 2: Create a void method that outputs an integer after dividing it by 2
        public void DivideByTwo(int num)
        {
            int result = num / 2;
            // Output the result to the console
            Console.WriteLine("The number divided by 2 is: " + result);
        }

        // Step 4: Create a method with output parameters
        public void MultiplyByTwo(int num, out int result)
        {
            result = num * 2; // Multiply the number by 2
        }

        // Step 5: Overload the MultiplyByTwo method to handle a different data type
        public void MultiplyByTwo(double num, out double result)
        {
            result = num * 2; // Multiply the number by 2 (for doubles)
        }
    }
}
