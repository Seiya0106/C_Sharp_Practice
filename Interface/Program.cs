using System;

namespace Sample
{
    // インターフェース
    public interface IMessage
    {
        void Hello();
    }

    // インターフェースを実装するクラス
    class View : IMessage
    {
        public void Morning()
        {
            Console.WriteLine("おはよう");
        }
        public void Hello()
        {
            Console.WriteLine("こんにちは");
        }
    }

    // メインクラス
    class Sample
    {
        static void Main(string[] args)
        {
            View vw = new View();

            vw.Morning();
            vw.Hello();
        }
    }
}