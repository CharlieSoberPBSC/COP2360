using System;

partial class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter two numbers to divide:");
            Console.Write("First number: ");
            string input1 = Console.ReadLine();
            Console.Write("Second number: ");
            string input2 = Console.ReadLine();

            int number1, number2;
            bool parseSuccess1 = int.TryParse(input1, out number1);
            bool parseSuccess2 = int.TryParse(input2, out number2);

            if (!parseSuccess1 || !parseSuccess2)
            {
                throw new FormatException("Invalid input format. Please enter valid integers.");
            }

            try
            {
                // Perform division
                int result = DivideNumbers(number1, number2);
                Console.WriteLine($"Result of division: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The numbers are too large to process.");
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Format Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static int DivideNumbers(int dividend, int divisor)
    {
        return dividend / divisor;
    }
}