// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of MathOperations
        MathOperations operations = new MathOperations();

        // Ask the user for a number
        Console.WriteLine("Enter a number to perform math operations:");
        int input = Convert.ToInt32(Console.ReadLine());

        // Call the Square method and display the result
        int squareResult = operations.Square(input);
        Console.WriteLine($"The square of {input} is {squareResult}.");

        // Call the Cube method and display the result
        int cubeResult = operations.Cube(input);
        Console.WriteLine($"The cube of {input} is {cubeResult}.");

        // Call the Double method and display the result
        int doubleResult = operations.Double(input);
        Console.WriteLine($"Double of {input} is {doubleResult}.");
    }
}
