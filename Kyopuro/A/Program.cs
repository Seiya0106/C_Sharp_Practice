using System;
using System.Collections.Generic;

namespace A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]input = Console.ReadLine().Split(" ");
            int r = int.Parse(input[0]);
            int g = int.Parse(input[1]);
            int b = int.Parse(input[2]);
            string c = Console.ReadLine();
            if (c == "Red")
            {
                if (g > b)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(g);
                }
            }
            else if (c == "Green")
            {
                if (r > b)
                {
                    Console.WriteLine(b);
                }
                else
                {
                    Console.WriteLine(r);
                }
            }
            else
            {
                if (r > g)
                {
                    Console.WriteLine(g);
                }
                else
                {
                    Console.WriteLine(r);
                }
            }
        }
    }
}