using System;
using System.Collections.Generic;

namespace sample6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["cat"] = "猫";
            dic["dog"] = "犬";
            dic["bird"] = "鳥";
            dic["tiger"] = "トラ";
            Console.Write("英語で動物の名前を入力してください：");
            string input = Console.ReadLine();
            Console.WriteLine("「{0}」です", dic[input]);
        }
    }
}