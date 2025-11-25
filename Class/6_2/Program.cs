using System;

class Calc
{
    public double Add(double n1, double n2)
    {
        return n1 + n2;
    }
    public double Sub(double n1, double n2)
    {
        return n1 - n2;
    }
    public double Mul(double n1, double n2)
    {
        return n1 * n2;
    }
    public double Div(double n1, double n2)
    {
        return n1 / n2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calc c = new Calc();
        double a = 4.6, b = 2.3;
        Console.WriteLine(a + " + " + b + " = " + c.Add(a, b));
        Console.WriteLine(a + " - " + b + " = " + c.Sub(a, b));
        Console.WriteLine(a + " * " + b + " = " + c.Mul(a, b));
        Console.WriteLine(a + " / " + b + " = " + c.Div(a, b));
    }
}