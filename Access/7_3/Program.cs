using System;

class Calculation
{
    private int number1 = 0;
    private int number2 = 0;
    public int Number1
    {
        set { number1 = value; }
        get { return number1; }
    }
    public int Number2
    {
        set { number2 = value; }
        get { return number2; }
    }
    public int Add()
    {
        return number1 + number2;
    }
    public int Sub()
    {
        return number1 - number2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculation c = new Calculation();
        c.Number1 = 8;    //  一つ目の数をセット
        c.Number2 = 9;    //  二つ目の数をセット
        //  二つの数の和を表示
        Console.WriteLine("{0} + {1} = {2}",c.Number1,c.Number2,c.Add());
        //  二つの数の差を表示
        Console.WriteLine("{0} - {1} = {2}",c.Number1,c.Number2,c.Sub());
    }
}