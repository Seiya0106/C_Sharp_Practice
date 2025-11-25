using System;

class Airplane
    {
        public void Fly(){
            Console.WriteLine("飛行する");
        }
    }

class Fighter : Airplane
{
    public void Fight()
    {
        Console.WriteLine("戦闘する");
    }
}
class Program
    {
        static void Main(string[] args)
        {
            Fighter f = new Fighter();      //  戦闘機クラス
            Airplane a = new Airplane();    //  飛行機クラス
            //  飛行機が飛行する
            a.Fly();
            //  戦闘機が飛行する
            f.Fly();
            //  戦闘機が戦闘する
            f.Fight();
        }
    }