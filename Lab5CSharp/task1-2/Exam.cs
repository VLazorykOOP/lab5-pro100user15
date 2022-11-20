namespace pro100user.task2;

//Іспит
public class Exam : Test
{
    public Exam()
    {
        Console.WriteLine("Constructor \"Exam\"");
    }
    
    public Exam(string name) : base(name)
    {
        Console.WriteLine("Constructor \"Exam\"");
    }
    
    public Exam(string name, string finalDate) : base(name, finalDate)
    {
        Console.WriteLine("Constructor \"Exam\"");
    }
    
    ~Exam()
    {
        Console.WriteLine("Destructor \"Exam\"");
    }
    
    public override void Show()
    {
        Console.WriteLine($"Exam {name} <- Test <- Examination");
    }
}