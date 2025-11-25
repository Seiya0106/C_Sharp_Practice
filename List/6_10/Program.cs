using System;
using System.Collections.Generic;

namespace sample6_10
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet <int> s = new HashSet<int>();
            Random rnd = new Random();
            Console.Write("乱数：");
            for (int i = 0; i < 10; i++)
            {
                int num = rnd.Next(1, 11);
                Console.Write(num + " ");
                s.Add(num);
            }
            Console.Write("\n出現した数：");
            foreach (int n in s)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}