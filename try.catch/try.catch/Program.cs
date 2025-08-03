using System;

class Program
{
    static void Main()
    {
        try
        {
            // Prompt the user for their age
            Console.Write("Please enter your age: ");
            string input = Console.ReadLine();

            // Convert the input string to an integer
            int age = int.Parse(input);

            // Validate the age to ensure it's a positive number
            if (age <= 0)
            {
                throw new ArgumentException("Age cannot be zero or negative.");
            }

            // Calculate the birth year
            int currentYear = DateTime.Now.Year;
            int birthYear = currentYear - age;

            // Display the birth year
            Console.WriteLine($"You were born in {birthYear}.");
        }
        catch (FormatException)
        {
            // Handle cases where the user enters non-numeric values
            Console.WriteLine("Invalid input. Please enter a valid numeric age.");
        }
        catch (ArgumentException ex)
        {
            // Handle cases where the user enters zero or negative numbers
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Catch any other unexpected exceptions
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}