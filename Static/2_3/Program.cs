using System;

class Square
{
    public static void DrawSquare(int line, int col)
    {
        for (int i = 0; i < col; i++)
        {
            for (int j = 0; j < line; j++)
            {
                Console.Write("■");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int line = rnd.Next(1, 11);
        int col = rnd.Next(1, 11);
        Console.WriteLine("たて：{0}", line);
        Console.WriteLine("よこ：{0}", col);
        Console.WriteLine();
        Square.DrawSquare(line, col);
    }
}