using System;

public class LoopAndFunction
{
    public void PrintNumbers()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    public void GetUserInput()
    {
        string input;
        while (true)
        {
            Console.Write("Enter a value (type 'exit' to quit): ");
            input = Console.ReadLine()?.ToLower();
            if (input == "exit")
            {
                Console.WriteLine("Exiting...");
                break;
            }
            Console.WriteLine($"You entered: {input}");
        }
    }

    public int CalculateFactorial(int num)
    {
        int fact = 1;
        for (int i = 1; i <= num; i++)
        {
            fact *= i;
        }
        return fact;
    }
}

class Program
{
    static void Main()
    {
        LoopAndFunction lf = new LoopAndFunction();

        Console.WriteLine("Printing numbers from 1 to 10:");
        lf.PrintNumbers();

        Console.WriteLine("\nGetting user input until 'exit' is typed:");
        lf.GetUserInput();

        Console.Write("\nEnter a number to calculate its factorial: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = lf.CalculateFactorial(number);

        Console.WriteLine($"Factorial of {number} is {result}");
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
