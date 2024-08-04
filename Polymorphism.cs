public class Person
{
    public virtual void DisplayInfo()
    {
        Console.WriteLine("Person Info");
    }
}

public class Student : Person
{
    public override void DisplayInfo()
    {
        Console.WriteLine("Student Info");
    }
}
