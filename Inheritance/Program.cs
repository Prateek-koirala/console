class Person
{
    public string name = "Prateek"; //Person Field 
    public void hey() //Person Field
    {
        Console.WriteLine("Hey I am Prateek");
    }
}

class Surname : Person // derived class (child)
{
    public string surName = "Koirala"; //Surname field
}

class Program
{
    static void Main(string[] args)
    {
        //Create mySurname object 
        Surname mySurname = new Surname();

        mySurname.hey();

        Console.WriteLine(mySurname.name + " " + mySurname.surName);
    }
}