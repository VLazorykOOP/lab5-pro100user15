namespace pro100user.task3;

public class Hyperbola : Function
{
    private double K { get; set; }
    private double X { get; set; }

    public Hyperbola(double k, double x)
    {
        K = k;
        X = x;
    }

    public override double CalculateY()
    {
        Console.Write("Hyperbola: ");
        return K / X;
    }
}