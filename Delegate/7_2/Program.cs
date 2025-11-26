using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Problemex7_2
{
    //  デリゲート
    delegate void Delegatefunc(int num);
    class Showcharas
    {
        //  星を表示
        public void ShowStars(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write("☆");
            }
            Console.WriteLine();
        }
        //  資格を表示
        public void ShowBoxes(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write("■");
            }
            Console.WriteLine();
        }
        //  +を表示
        public void ShowPlus(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Showcharas s = new Showcharas();
            Delegatefunc f = new Delegatefunc(s.ShowStars);
            f += new Delegatefunc(s.ShowBoxes);
            f += new Delegatefunc(s.ShowPlus);
            f(4);
        }
    }
}