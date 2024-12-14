using System;
using System.Data;

public class Calculator
{
    public void Run()
    {
        bool continueCalculator = true;

        while (continueCalculator)
        {
            Console.Clear();
            Console.WriteLine("Enter your expression (e.g., 3+5-6*4/7=) or type 'exit' to quit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                continueCalculator = false;
                Console.WriteLine("\nExiting the calculator. Goodbye!");
                break;
            }

            // Remove the trailing '=' sign if it exists
            if (input.EndsWith("="))
            {
                input = input.TrimEnd('=');
            }

            try
            {
                // Evaluate the expression
                double result = EvaluateExpression(input);
                Console.WriteLine($"\nResult: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    private double EvaluateExpression(string expression)
    {
        // Using DataTable to evaluate the expression
        var table = new DataTable();
        var result = table.Compute(expression, string.Empty);
        return Convert.ToDouble(result);
    }
}
