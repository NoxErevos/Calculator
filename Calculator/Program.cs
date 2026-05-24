using System.IO.Enumeration;
using System.Linq.Expressions;

namespace Calculator;

internal class Program
{
    private const string Version = "v0.0.1";

    public static int Main()
    {
        return MainLoop();
    }

    private static int InputLoop()
    {
        Console.Write("> ");
        try
        {
            var operation = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    Power();
                    break;
                case 6:
                    return 0;
                default:
                    Console.WriteLine("Invalid operation");
                    InputLoop();
                    break;
            }
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Please enter a number");
            InputLoop();
        }

        InputLoop();
        return 0;
    }

    private static int MainLoop()
    {
        Console.WriteLine($"Welcome to Calculator {Version}");
        Console.WriteLine("Choose your operation: ");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Power");
        Console.WriteLine("6. Exit");
        return InputLoop();
    }

    private static void Addition()
    {
        var (a, b) = GetNum();
        Console.WriteLine($"{a+b}");
        return;
    }

    private static void Subtraction()
    {
        var (a, b) = GetNum();
        Console.WriteLine($"{a-b}");
        return;
    }

    private static void Multiplication()
    {
        var (a, b) = GetNum();
        Console.WriteLine($"{a*b}");
        return;
    }

    private static void Division()
    {
        var (a, b) = GetNum();
        Console.WriteLine($"{a/b}");
        return;
    }

    private static void Power()
    {
        Console.Write("Enter number: ");
        var a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter power: ");
        var b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{Math.Pow(a, b)}");
        return;
    }

    private static (double a, double b) GetNum()
    {
        double a, b;
        Console.Write("Enter first number: ");
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("Please enter a number");
            Console.Write("Enter first number: ");
        }
        Console.Write("Enter second number: ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Please enter a number");
            Console.Write("Enter second number: ");
        }
        return (a, b);
    }
}