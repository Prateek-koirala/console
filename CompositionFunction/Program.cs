using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Result: " + ComposedFunction(3));
    }

    static int AddTwo(int x)
    {
        return x + 2;
    }

    static int MultiplyByThree(int y)
    {
        return y * 3;
    }

    static int ComposedFunction(int x)
    {
        return MultiplyByThree(AddTwo(x));
    }
}
