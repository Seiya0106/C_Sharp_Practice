using System;

namespace sample
{
    class Parent
    {
        public virtual void Foo()
        {
            Console.WriteLine("親クラスのFoo()メソッド");
        }
    }
    class Child : Parent
    {
        public override void Foo()
        {
            Console.WriteLine("子クラスのFoo()メソッド");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //  Parentクラスのインスタンス生成
            Parent p = new Parent();
            //  Childクラスのインスタンス生成
            Parent c = new Child();
            //  それぞれのクラスのfoo、barメソッドを実行
            p.Foo();
            c.Foo();
        }
    }
}