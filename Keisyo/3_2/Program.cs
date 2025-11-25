using System;

namespace Problemex3_2
{
    class FundCalc
    {
        private double number1 = 0.0;   //  一つ目の数
        private double number2 = 0.0;   //  二つ目の数
        //  number1のプロパティ
        public double Number1
        {
            set { number1 = value; }
            get { return number1; }
        }
        //  number2のプロパティ
        public double Number2
        {
            set { number2 = value; }
            get { return number2; }
        }
        //  二つの数の和を出力
        public double Add()
        {
            return number1 + number2;
        }
        //  二つの数の差を出力
        public double Sub()
        {
            return number1 - number2;
        }
    }

    class NewCalc : FundCalc
    {
        public double Mul()
        {
            return Number1 * Number2;
        }
        public double Div()
        {
            return Number1 / Number2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NewCalc n = new NewCalc();
            n.Number1 = 10;   //  一つ目の数を設定
            n.Number2 = 2;    //  二つ目の数を設定
            Console.WriteLine(n.Number1 + " + " + n.Number2 + " = " + n.Add());
            Console.WriteLine(n.Number1 + " - " + n.Number2 + " = " + n.Sub());
            Console.WriteLine(n.Number1 + " * " + n.Number2 + " = " + n.Mul());
            Console.WriteLine(n.Number1 + " / " + n.Number2 + " = " + n.Div());
        }
    }
}