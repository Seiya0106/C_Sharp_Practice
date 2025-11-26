using System;
using System.Collections;
using System.Collections.Generic;

namespace Problem4_1
{
    abstract class Animal
    {
        protected string name = "";
        public abstract void Bark();
        public abstract void Move();
        public void ShowName()
        {
            Console.WriteLine("名前：{0}", name);
        }
    }
    
    class Dog : Animal
    {
        public Dog()
        {
            name = "犬";
        }
        public override void Bark()
        {
            Console.WriteLine("ワンワン");
        }
        public override void Move()
        {
            Console.WriteLine("歩く");
        }
    }

    class Monkey : Animal
    {
        public Monkey()
        {
            name = "猿";
        }
        public override void Bark()
        {
            Console.WriteLine("キーキー");
        }
        public override void Move()
        {
            Console.WriteLine("木に登る");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //  Animalクラスのオブジェクトの配列を生成
            Animal[] animals = new Animal[2];
            animals[0] = new Dog();     //  犬クラスのインスタンス生成
            animals[1] = new Monkey();  // 猿クラスのインスタンスの生成
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].ShowName();
                animals[i].Move();
                animals[i].Bark();
                Console.WriteLine("------------");
            }
        }
    }
}