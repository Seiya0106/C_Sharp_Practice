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
            data[i] = rnd.Next(1, 11);
            Console.Write(data[i] + " ");
        }
        Console.WriteLine("\n");
        Console.WriteLine("合計値：" + data.Sum());
        double ave = data.Average();
        Console.WriteLine("平均値：" + ave);
        Console.Write("平均値より大きい値：");
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] > ave)
            {
                Console.Write(data[i] + " ");
            }
        }
        Console.WriteLine();
        Console.Write("平均値より小さい値：");
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] < ave)
            {
                Console.Write(data[i] + " ");
            }
        }
        Console.WriteLine();
    }
}