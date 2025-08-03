using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace fewArraysTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is test tasks");
            Console.WriteLine("Choose your task you want to see from 1 to 6  ");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
                case 7:
                    Task7();
                    break;
            }

            void Task1()
            {
                String[] cars = { "bmw", "Mercedes", "Audi" };
                Console.WriteLine("please choose car make");
                String carChoose = Console.ReadLine();

                for (int i = 0; i < cars.Length; i++)
                {
                    cars[i] += " " + carChoose;
                }
                foreach (string car in cars)
                {
                    Console.WriteLine(car);
                }

            }
            void Task2()
            {
                bool condi = true; // Set initial condition to true for an infinite loop
                while (condi) // Loop while condi is true
                {
                    Console.WriteLine("Infinity loop, press 'q' to quit");

                    string input = Console.ReadLine();

                    if (input == "q")
                    {
                        condi = false; // Set condition to false to break the loop
                    }
                }
            }
            void Task3()
            {
                List<String> fruits = new List<String> { "apple", "banana", "kivi", "orange" };
                Console.WriteLine(" search from the list we made");

                String searchText = Console.ReadLine();
                bool found = false;
                for (int i = 0; i < fruits.Count; i++)
                {
                    if (fruits[i].Contains(searchText))
                    {
                        Console.WriteLine($"Match found at index {1}: {fruits[i]}");
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Your input is not on the list.");
                }
            }
            void Task4()
            {
                List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

                // Ask the user for a number to divide each list element by
                Console.Write("Enter a number to divide each number in the list by: ");
                string input = Console.ReadLine();

                // Try-Catch block to handle possible errors
                try
                {
                    // Attempt to parse the input to a number
                    int divisor = int.Parse(input);

                    // Iterate over the list and divide each number by the user input
                    foreach (int number in numbers)
                    {
                        int result = number / divisor;
                        Console.WriteLine($"{number} divided by {divisor} equals {result}");
                    }
                }
                catch (FormatException ex)
                {
                    // Handle invalid input like strings
                    Console.WriteLine("Error: Invalid input. Please enter a valid number.");
                    Console.WriteLine("Details: " + ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    // Handle division by zero
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    Console.WriteLine("Details: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Catch any other unexpected exceptions
                    Console.WriteLine("An unexpected error occurred.");
                    Console.WriteLine("Details: " + ex.Message);
                }
                finally
                {
                    // The code in the finally block always runs, whether there was an exception or not
                    Console.WriteLine("Program execution has continued after the try/catch block.");
                }
            }

            void Task5()
            {
                Deck deck = new Deck();
                deck.Shuffle(3);


                foreach (Card card in deck.Cards)
                {
                    Console.WriteLine(card.Face + " of " + card.Suit);
                }

                Console.WriteLine(deck.Cards.Count);
                Console.WriteLine(deck.Cards[0].Face + " " + deck.Cards[0].Suit);
                //Card cardOne = new Card();
                //Deck deck = new Deck();

                //deck.Cards = new List<Card>();

                //cardOne.Face = "Queen";
                //cardOne.Suit = "spades";

                //deck.Cards.Add(cardOne);
                //Console.WriteLine(cardOne.Face + " " + cardOne.Suit);
            }
            void Task6()
            {
                // Create an instance of the MathOperations class
                MathOperations mathOps = new MathOperations();

                // Ask the user for a number to perform operations on
                Console.Write("Enter a number to perform math operations on: ");
                string input = Console.ReadLine();  // Read user input as a string

                // Convert the input string to an integer
                int userNumber;
                if (int.TryParse(input, out userNumber))  // TryParse safely converts the string to an integer
                {
                    // Call the AddTen method and display the result
                    int result1 = mathOps.AddTen(userNumber);
                    Console.WriteLine("Result after adding 10: " + result1);  // Output the result of AddTen

                    // Call the MultiplyByFive method and display the result
                    int result2 = mathOps.MultiplyByFive(userNumber);
                    Console.WriteLine("Result after multiplying by 5: " + result2);  // Output the result of MultiplyByFive

                    // Call the SubtractThree method and display the result
                    int result3 = mathOps.SubtractThree(userNumber);
                    Console.WriteLine("Result after subtracting 3: " + result3);  // Output the result of SubtractThree
                }
                else
                {
                    // If the user input is not a valid integer, display an error message
                    Console.WriteLine("Please enter a valid integer.");
                }


            }
            void Task7()
            {
                // Step 3: Instantiate the class
                NumberOperations numberOperations = new NumberOperations();

                // Ask the user to input a number
                Console.Write("Please enter a number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                // Call the method to divide the user's number by 2
                numberOperations.DivideByTwo(userInput);

                // Step 4: Call the MultiplyByTwo method using output parameters
                numberOperations.MultiplyByTwo(userInput, out int multipliedResult);
                Console.WriteLine("The number multiplied by 2 is: " + multipliedResult);

                // Step 5: Demonstrate method overloading
                numberOperations.MultiplyByTwo(7.5, out double doubleMultipliedResult);
                Console.WriteLine("The double number multiplied by 2 is: " + doubleMultipliedResult);

                // Step 6: Use static methods from the static class
                MathOperation.DivideByTwo(userInput, out int dividedResultStatic);
                Console.WriteLine("Using static class: The number divided by 2 is: " + dividedResultStatic);

                MathOperation.DivideByTwo(15.8, out double dividedDoubleResultStatic);
                Console.WriteLine("Using static class: The double number divided by 2 is: " + dividedDoubleResultStatic);

                Console.ReadLine(); // Keep the console open until the user presses Enter
            }

                Console.ReadLine();

        }
    }
}

