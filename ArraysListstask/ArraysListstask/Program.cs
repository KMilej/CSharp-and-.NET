using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ArraysListstask
{
    internal class Program {
        static void Main(string[] args) {
            string[] cars = { "bmw", "audi", "mercedes", "fiat", "toyota" };

            // Ask the user to select an index in our array list
            Console.WriteLine("Please enter an index between 0 and " + (cars.Length - 1) + ": ");
            int placeInArray = int.Parse(Console.ReadLine());

            if (placeInArray >= 0 && placeInArray < cars.Length)
            {
                Console.WriteLine("The String at index " + placeInArray + " is: " + cars[placeInArray]);
            }
            else
            {
                Console.WriteLine("an index doesn’t exist. Please enter a number between 0 and " + (cars.Length - 1) + ".");
               
            }

            int[] numbersList = { 1, 2, 3, 4, 5, 6, };

            Console.WriteLine("Please enter an index between 0 and " + (numbersList.Length - 1) + ": ");
            int placeIn = int.Parse(Console.ReadLine());

            if (placeInArray >= 0 && placeInArray <= numbersList.Length) { 
                Console.WriteLine("The String at index " + placeIn + " is: " + numbersList[placeIn]);
        }
            else
            {
                Console.WriteLine("an index doesn’t exist. Please enter a number between 0 and " + ((numbersList.Length - 1) + "."));
               
            }

            List<string> arrows = new List<string>()
            {
                "Up",
                "Down",
                "left",
                "right"
            };

            Console.WriteLine("\n Select \n another number between 0 " + ((arrows.Count - 1) + "."));
            int Select = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            while (!validList) {
                try
                {
                    Console.WriteLine("you chose " + arrows[Select]);
                    validList = true;
                }
                catch {
                    Console.WriteLine("the number you chose is not valid, try again from 0 to " + ((arrows.Count-1) + "."));
                    Select = Convert.ToInt32(Console.ReadLine());
                }
            
            }


            Console.ReadLine();
        }
    }
}
