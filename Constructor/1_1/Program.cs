using System;

namespace sample1_1
{
    class Sample
    {
        public Sample()
        {
            Console.WriteLine("コンストラクタ");
        }
        public void foo()
        {
            Console.WriteLine("foo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.foo();
        }
    }
}