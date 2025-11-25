using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int [] data = new int[5];
        Random rnd = new Random();
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = rnd.Next(-10, 11);
            Console.Write(data[i] + " ");
        }
        Console.WriteLine();
        int cntOver = 0;
        int cntUnder = 0;
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] > 0)
            {
                cntOver++;
            }
            else if (data[i] < 0)
            {
                cntUnder++;
            }
        }
        Console.WriteLine("0より大きい数：" + cntOver + "個");
        Console.WriteLine("0より小さい数：" + cntUnder + "個");
        int cntZero = data.Length - cntOver - cntUnder;
        Console.WriteLine("0の数：" + cntZero + "個");
    }
}