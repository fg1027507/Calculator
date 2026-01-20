/* 
Calculator
Created by Finn Gilbert
Created on 1/13/2026
*/

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("=== Enhanced Calculator ===");
                Console.WriteLine("This program demonstrates a calculator with:");
                Console.WriteLine("- Classes and methods in separate files");
                Console.WriteLine("- Exception handling for division by zero");
                Console.WriteLine("- Random number generation");
                Console.WriteLine("- User input capabilities");
                Console.WriteLine();

                // Create calculator instance
                Calculator calc = new Calculator();

                Console.Write("You can also enter your own numbers for calculations? (y/n): ");
                string userChoiceNum = (Console.ReadLine() ?? "n").Trim().ToLower();
                Console.WriteLine();

                int x = 0;
                int y = 0;

                if (userChoiceNum == "y")
                {
                    Console.Write("Enter the first number: ");
                    x = int.Parse(Console.ReadLine() ?? "100");

                    Console.Write("Enter the second number: ");
                    y = int.Parse(Console.ReadLine() ?? "50");
                }
                else
                {
                    // Generate and display random numbers
                    Random random = new Random();
                    x = random.Next(1, 101); // 1-100 inclusive
                    y = random.Next(0, 51);  // 0-50 inclusive
                }

                Console.WriteLine($"Numbers used:");
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"y = {y}");
                Console.WriteLine();

                // Perform all operations with results
                Console.WriteLine("Performing calculations:");
                // Addition
                double addResult = calc.Add(x, y);
                Console.WriteLine($"{x} + {y} = {addResult}");

                // Subtraction
                double subResult = calc.Sub(x, y);
                Console.WriteLine($"{x} - {y} = {subResult}");

                // Multiplication
                double mulResult = calc.Mul(x, y);
                Console.WriteLine($"{x} * {y} = {mulResult}");

                // Division with exception handling
                try
                {
                    double divResult = calc.Div(x, y);
                    Console.WriteLine($"{x} / {y} = {divResult}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"{x} / {y} = Error: {ex.Message}");
                }
                // Modulus with exception handling
                try
                {
                    double modResult = calc.Mod(x, y);
                    Console.WriteLine($"{x} % {y} = {modResult}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"{x} % {y} = Error: {ex.Message}");
                }
                Console.WriteLine();
                Console.WriteLine("Program completed successfully with all requirements met!");
                Console.Write("Do you want to perform another calculation? (y/n): ");
            } while (string.Equals((Console.ReadLine() ?? "n").Trim(), "y", StringComparison.OrdinalIgnoreCase));
        }
    }
}