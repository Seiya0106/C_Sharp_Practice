using System;

class Program
{
    static void Main(string[] args)
    {
        int [] data = new int[10];
        Random rnd = new Random();
        int over = 0;
        int under = 0;
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = rnd.Next(0, 101);
            Console.Write(data[i] + " ");
            if (data[i] >= 50)
            {
                over++;
            }
            else if (data[i] < 50)
            {
                under++;
            }
        }
        Console.Write("\n50以上の数：");
        foreach (int d in data)
        {
            if (d >= 50)
            {
                Console.Write(d + " ");
            }
        }
        Console.Write("\n50未満の数：");
        foreach (int d in data)
        {
            if (d < 50)
            {
                Console.Write(d + " ");
            }
        }
        Console.WriteLine("\n0の個数：" + (data.Length - over - under) + "個");
    }
}