using System;

namespace sample
{
    class Data
    {
        private static int num = 0;
        private int id;
        public Data(int id)
        {
            this.id = id;
            num++;
            Console.WriteLine("値：{0} 数：{1}", this.id, num);
        }
        public static void ShowNumber()
        {
            Console.WriteLine("Dataオブジェクトの数{0}", num);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Data[] d = new Data[2];
            Data.ShowNumber();
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = new Data(i * 100);
                Data.ShowNumber();
            }
        }
    }
}