using System;
using System.Collections.Generic;

namespace sample6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> nums = new List<int>();
            Random rnd = new Random();
            while (true)
            {
                int num = rnd.Next(0, 11);
                Console.WriteLine("0～10の値を出力:" + num);
                if (num == 0)
                {
                    break;
                }
                else
                {
                    nums.Add(num);
                }
            }
            Console.Write("\n偶数 : ");
            foreach (int n in nums)
            {
                if (n % 2 == 0)
                {
                    Console.Write(n + " ");
                }
            }
            Console.Write("\n奇数 : ");
            foreach (int n in nums)
            {
                if (n % 2 != 0)
                {
                    Console.Write(n + " ");
                }
            }
            Console.WriteLine();
        }
    }
}