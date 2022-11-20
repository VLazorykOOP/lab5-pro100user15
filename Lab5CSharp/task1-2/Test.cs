namespace pro100user.task2;

//Тест
public class Test : Examination
{
    public Test()
    {
        Console.WriteLine("Constructor \"Test\"");
    }
    
    public Test(string name) : base(name)
    {
        Console.WriteLine("Constructor \"Test\"");
    }
    
    public Test(string name, string finalDate) : base(name, finalDate)
    {
        Console.WriteLine("Constructor \"Test\"");
    }
    
    ~Test()
    {
        Console.WriteLine("Destructor \"Test\"");
    }
    
    public override void Show()
    {
        Console.WriteLine($"Test \"{name}\" <- Examination");
    }
}