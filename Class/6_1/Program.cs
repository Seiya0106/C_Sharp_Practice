using System;

namespace Practice6_1
{
    //  最大値と最小値を求めるクラス
    class MinMax
    {
        //  最大値の取得
        public int Max(int n1, int n2, int n3)
        {
            if (n1 > n2)
            {
                if (n3 > n1)
                {
                    return n3;
                }
                else
                {
                    return n1;
                }
            }
            else
            {
                if (n3 > n2)
                {
                    return n3;
                }
                else
                {
                    return n2;
                }
            }
        }
        //  最小値の取得
        public int Min(int n1, int n2, int n3)
        {
            if (n1 < n2)
            {
                if (n3 < n1)
                {
                    return n3;
                }
                else
                {
                    return n1;
                }
            }
            else
            {
                if (n3 < n2)
                {
                    return n3;
                }
                else
                {
                    return n2;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MinMax m = new MinMax();
            int a = 4,b = 2,c = -1;
            Console.WriteLine("{0}と{1}と{2}のうち、最大のものは{2}",a,b,m.Max(a,b,c));
            Console.WriteLine("{0}と{1}と{2}のうち、最小のものは{2}",a,b,m.Min(a, b,c));
        }
    }
}