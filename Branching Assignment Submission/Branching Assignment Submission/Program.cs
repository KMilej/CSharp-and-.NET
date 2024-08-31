using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment_Submission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");
            Console.WriteLine("if you want send package please enter the parameters");
            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine()); //prompt package weight


            // Check if the package weight is greater than 50
            string Weight = packageWeight > 50 ? "Package too heavy to be shipped via Package Express. Have a good day." : "Good, we accept packages with weight " + packageWeight + " Kg.";
            Console.WriteLine(Weight);

            Console.WriteLine("Please enter the package width:");
            int packageWidth = Convert.ToInt32(Console.ReadLine());  //prompt package width

            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine()); //prompt package height

            Console.WriteLine("Please enter the package lenght:");
            int packageLenght = Convert.ToInt32(Console.ReadLine());  //prompt package lenght

            //int packageSize = packageHeight + packageLenght + packageWidth;

            // Check if the sum of dimensions is more then 50
            string totalSize = (packageWidth + packageHeight + packageLenght > 50) ? 
                               "Package too big to be shipped via Package Express. Have a good day, bye." : 
                               "Good, we accept this size of package.";
            Console.WriteLine(totalSize);

            // Calculate the cost of shipping based on size and weight
            int totalsizint = packageWidth * packageHeight * packageLenght;
            int packageCost = (totalsizint * packageWeight) / 100;
            Console.WriteLine("you have to pay a package cost: " + packageCost + " $");

            // Wait for user input before closing
            Console.ReadLine();

        }
    }
}
