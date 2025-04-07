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
        if (b == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return double.NaN;
        }
        return a / b;
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

        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

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
