using System;

namespace sample1_2
{
    class Calc
    {
        public Calc()
        {
            num1 = 0;
            num2 = 0;
        }
        public Calc(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        //  一つ目の数
        private int num1;
        //  二つ目の数
        private int num2;
        //  一つ目の数のプロパティ
        public int Num1
        {
            set { num1 = value; }
            get { return num1; }
        }
        //  二つ目の数のプロパティ
        public int Num2
        {
            set { num2 = value; }
            get { return num2; }
        }
        public void ShowAdd()
        {
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calc c1 = new Calc(),c2 = new Calc(3,1);
            c1.Num1 = 1;
            c1.Num2 = 2;
            //  加算の結果を表示
            c1.ShowAdd();
            c2.ShowAdd();
        }
    }
}