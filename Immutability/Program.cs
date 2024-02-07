using System;

public class ImmutablePerson
{
    public readonly string FirstName;
    public readonly string LastName;

    public ImmutablePerson(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName} ";
    }


}



class Program
{
    static void Main(string[] args)
    {
        ImmutablePerson person = new ImmutablePerson("Prateek", "Koirala");

        Console.WriteLine("First Name:");
        Console.WriteLine(person);

        // person.FirstName = "Pramit";
    }
}