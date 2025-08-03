using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fewArraysTasks
{
    internal class ClassMethodAssignment
    {
        // Step 6: Declare a static class (Static classes cannot be instantiated and can only contain static members)
        static class MathOperations
        {
            // Static method that divides a number by 2
            public static void DivideByTwo(int num, out int result)
            {
                // Divide the number by 2 and assign the result to the output parameter
                result = num / 2;
            }

            // Step 5: Overload the DivideByTwo method to work with floating-point numbers
            public static void DivideByTwo(double num, out double result)
            {
                // Divide the number by 2 and assign the result to the output parameter
                result = num / 2;
            }
        }
    }
}
