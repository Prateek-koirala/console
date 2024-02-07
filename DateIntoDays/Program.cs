using System;

public class Date
{
    //Implementation of immutability
    public readonly int Year;
    public readonly int Month;
    public readonly int Day;

    public Date(int year, int month, int day)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    //Implementation of Pure  Function 
    public int ConvertToDays()
    {
        return 365 * Year - ((Month * 30) + Day);
    }

    public override string ToString()
    {
        return $"{Year}-{Month:D2}-{Day:D2}";
    }
}

class Program
{
    // Implementation of Function composition
    static Func<Date, int> GetDays = date => date.ConvertToDays();

    // Implementation of Higher-order function 
    static int DateDifference(Func<Date, int> getDateValue, Date date1, Date date2)
    {
        return getDateValue(date1) - getDateValue(date2);
    }

    static void Main(string[] args)
    {
        Date date1 = new Date(2080, 1, 30);
        Date date2 = new Date(2080, 2, 10);

        int finalDayDifference = DateDifference(GetDays, date1, date2);

        Console.WriteLine("The number of days between two dates (2080-01-30 and 2080-02-10) is : ");
        Console.WriteLine(finalDayDifference);
    }
}