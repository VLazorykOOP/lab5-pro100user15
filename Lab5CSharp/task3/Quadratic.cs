namespace pro100user.task3;

public class Quadratic : Function
{
    private double A { get; set; }
    private double B { get; set; }
    private double C { get; set; }
    private double X { get; set; }

    public Quadratic(double a, double b, double c, double x)
    {
        A = a;
        B = b;
        C = c;
        X = x;
    }

    public override double CalculateY()
    {
        Console.Write("Quadratic: ");
        return A * Math.Pow(X, 2) + B * X + C;
    }
}