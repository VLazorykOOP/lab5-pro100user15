namespace pro100user.task2;

//Випробування
public class Examination
{
    protected string name;
    
    public Examination()
    {
        name = "someexam";
        Console.WriteLine("Constructor \"Examination\"");
    }
    
    public Examination(string name)
    {
        this.name = name;
        Console.WriteLine("Constructor \"Examination\"");
    }
    
    public Examination(string name, string finalDate)
    {
        this.name = name + finalDate;
        Console.WriteLine("Constructor \"Examination\"");
    }
    
    ~Examination()
    {
        Console.WriteLine("Destructor \"Examination\"");
    }

    public virtual void Show()
    {
        Console.WriteLine($"Examination \"{name}\"");
    }
}