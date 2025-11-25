using System;
using System.Collections.Generic;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> a = new List<string>();
            // データを追加
            a.Add("Taro");
            a.Add("Hanako");
            a.Add("Jiro");
            a.Add("Kaoru");
            // データを削除
            a.Remove("Taro");
            a.RemoveAt(1);
            foreach (string s in a)
            {
                Console.WriteLine(s);
            }
        }
    }
}