using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Current Time: " + GetCurrentTime());
    }

    static DateTime GetCurrentTime()
    {
        return DateTime.Now;
    }
}
