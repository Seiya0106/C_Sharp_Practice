using System;

class Data
{
    //  メンバ変数number
    private int number = 0;
    //  メンバ変数comment
    private string comment = "";
    // 数字の設定
    public int Number
    {
        set { number = value; }
        get { return number; }
    }
    public string Comment
    {
        set { comment = value; }
        get { return comment; }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Data d = new Data();
        d.Number = 100;
        d.Comment = "Programming C#";
        Console.WriteLine("number = " + d.Number);
        Console.WriteLine("comment = " + d.Comment);
    }
}
