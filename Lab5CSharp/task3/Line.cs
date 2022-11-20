namespace pro100user.task3;

public class Line : Function
{
    private double A { get; set; }
    private double B { get; set; }
    private double X { get; set; }

    public Line(double a, double b, double x)
    {
        A = a;
        B = b;
        X = x;
    }

    public override double CalculateY()
    {
        Console.Write("Line: ");
        return A * X + B;
    }
}