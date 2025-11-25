using System;

namespace Problemex2_4
{
    class Counter
    {
        //  カウント
        private int count = 0;
        // クラスそのものに属し、全インスタンスで共有される
        private static int totalcount = 0;
        //  コンストラクタ
        public void Reset()
        {
            totalcount -= count;
            count = 0;
        }
        //  カウントのインクリメント
        public void Increment()
        {
            count++;
            totalcount++;
        }
        //  回数のプロパティ
        public int Count
        {
            get
            {
                return count;
            }
        }
        public static int TotalCount
        {
            get
            {
                return totalcount;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter c1,c2;
            c1 = new Counter();
            c2 = new Counter();
            c1.Increment();
            c2.Increment();
            c2.Increment();
            c2.Reset();
            c1.Increment();
            c1.Increment();
            c2.Increment();
            Console.WriteLine("c1のカウント数：" + c1.Count);
            Console.WriteLine("c2のカウント数：" + c2.Count);
            Console.WriteLine("トータルのカウント数:" + Counter.TotalCount);
        }
    }
}