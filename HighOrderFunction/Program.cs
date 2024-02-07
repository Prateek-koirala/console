using System;

class Program
{
    static void Main()
    {

        int result1 = PerformOperation(5, 3, Add);
        Console.WriteLine("Result 1: " + result1);


        int result2 = PerformOperation(5, 3, Multiply);
        Console.WriteLine("Result 2: " + result2);
    }


    static int PerformOperation(int x, int y, Func<int, int, int> operation)
    {
        return operation(x, y);
    }


    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }
}
