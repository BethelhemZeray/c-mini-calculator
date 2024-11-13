using System;

public class Calculator
{
    public void Run()
    {
        bool continueCalculator = true;

        while (continueCalculator)
        {
            Console.Clear();
            DisplayMenu();

            Console.Write("Select an option from the menu above: ");
            string choice = Console.ReadLine();

            double num1, num2, result = 0;
            bool validOperation = true;

            // Handle the user's selection
            switch (choice)
            {
                case "0":  // Cancel operation
                    continueCalculator = false;
                    Console.WriteLine("\nExiting the calculator. Goodbye!");
                    break;

                case "1": // Addition
                    Console.Write("Enter the first number: ");
                    num1 = GetNumberInput();
                    Console.Write("Enter the second number: ");
                    num2 = GetNumberInput();
                    result = num1 + num2;
                    Console.WriteLine($"\nResult: {num1} + {num2} = {result}");
                    break;

                case "2": // Subtraction
                    Console.Write("Enter the first number: ");
                    num1 = GetNumberInput();
                    Console.Write("Enter the second number: ");
                    num2 = GetNumberInput();
                    result = num1 - num2;
                    Console.WriteLine($"\nResult: {num1} - {num2} = {result}");
                    break;

                case "3": // Multiplication
                    Console.Write("Enter the first number: ");
                    num1 = GetNumberInput();
                    Console.Write("Enter the second number: ");
                    num2 = GetNumberInput();
                    result = num1 * num2;
                    Console.WriteLine($"\nResult: {num1} * {num2} = {result}");
                    break;

                case "4": // Division
                    Console.Write("Enter the first number: ");
                    num1 = GetNumberInput();
                    Console.Write("Enter the second number: ");
                    num2 = GetNumberInput();
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"\nResult: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("\nError: Division by zero is not allowed.");
                        validOperation = false;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid selection. Please choose a valid option.");
                    validOperation = false;
                    break;
            }

            if (validOperation && choice != "0")
            {
                Console.WriteLine("\nOperation completed successfully.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Mini Calculator!");
        Console.WriteLine("Please choose an operation:");
        Console.WriteLine("0. Cancel");
        Console.WriteLine("1. Addition (+)");
        Console.WriteLine("2. Subtraction (-)");
        Console.WriteLine("3. Multiplication (*)");
        Console.WriteLine("4. Division (/)");
        Console.WriteLine("-----------------------------------");
    }

    private double GetNumberInput()
    {
        double number;
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }
        return number;
    }
}
