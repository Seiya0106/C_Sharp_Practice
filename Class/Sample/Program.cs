using System;

class Person
{
    public string name = "";
    public int age = 0;
    public void Show()
    {
        Console.WriteLine("名前：{0} 年齢：{1}歳", name, age);
    }
    public void Set(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person p1, p2;
        p1 = new Person();   // 1人目のインスタンス生成
        p2 = new Person();   // 2人目のインスタンス生成
        p1.name = "山田太郎";
        p1.age = 20;
        p2.Set("鈴木花子", 18);  // 2人目の情報をセット
        p1.Show();
        p2.Show();
    }
}