using System;

public class Calculator
{
    public double a { get; set; }
    public double b { get; set; }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        try
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
            return double.NaN;
        }
    }

    public void CheckEvenOrOdd(double num)
    {
        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} is an even number.");
        }
        else
        {
            Console.WriteLine($"{num} is an odd number.");
        }
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        double num1 = 0, num2 = 0;

        while (true)
        {
            try
            {
                Console.Write("Enter the first number: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        while (true)
        {
            try
            {
                Console.Write("Enter the second number: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        double sum = calc.Add(num1, num2);
        double difference = calc.Subtract(num1, num2);
        double product = calc.Multiply(num1, num2);
        double quotient = calc.Divide(num1, num2);

        Console.WriteLine("\n---- Results ----");
        Console.WriteLine($"Addition: {num1} + {num2} = {sum}");
        Console.WriteLine($"Subtraction: {num1} - {num2} = {difference}");
        Console.WriteLine($"Multiplication: {num1} * {num2} = {product}");

        if (!double.IsNaN(quotient))
        {
            Console.WriteLine($"Division: {num1} / {num2} = {quotient:F2}");
        }

        calc.CheckEvenOrOdd(sum);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
