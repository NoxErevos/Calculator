namespace Calculator;

internal class Program
{
    private const string Version = "v0.0.1";
    public static int Main()
    {
        Console.WriteLine($"Welcome to Calculator {Version}");
        Console.WriteLine("Choose your operation: ");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("5. Power");
        Console.Write("> ");
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
            default:
                Console.WriteLine("Invalid operation");
                break;
        }
        return 0;
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
        Console.Write("Enter first number: ");
        var a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        var b = Convert.ToDouble(Console.ReadLine());
        return (a, b);
    }
}