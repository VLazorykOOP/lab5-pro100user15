namespace pro100user.task2;

//Випускний іспит
public class FinalExam : Exam
{
    public FinalExam()
    {
        Console.WriteLine("Constructor \"FinalExam\"");
    }
    
    public FinalExam(string name) : base(name)
    {
        Console.WriteLine("Constructor \"Exam\"");
    }
    
    public FinalExam(string name, string finalDate) : base(name, finalDate)
    {
        Console.WriteLine("Constructor \"Exam\"");
    }
    
    ~FinalExam()
    {
        Console.WriteLine("Destructor \"FinalExam\"");
    }
    
    public override void Show()
    {
        Console.WriteLine($"FinalExam \"{name}\" <- Exam <- Test <- Examination");
    }
}