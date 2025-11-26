using System;

namespace Problemex4_2
{
    abstract class PlaneFigure
    {
        //  幅
        protected double width = 0;
        //  高さ
        protected double height = 0;
        //  幅のプロパティ
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        //  高さのプロパティ
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        //  面積の取得
        public abstract double Area
        {
            get;
        }
    }
    //  四角形クラス
    class Box : PlaneFigure
    {
        //  コンストラクタ（引数なし）
        public Box()
        {
        }
        //  コンストラクタ（引数あり）
        public Box(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double Area
        {
            get{ return Width * Height; } 
        }
    }

    //  三角形クラス
    class Triangle : PlaneFigure
    {
        //  コンストラクタ（引数なし）
        public Triangle()
        {
        }
        //  コンストラクタ（引数あり）
        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        //  面積の取得
        public override double Area
        {
            get { return Width * Height / 2.0; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //  四角形の生成
            Box b = new Box(2.0,4.0);
            //  三角形の生成
            Triangle t = new Triangle(4.0, 1.5);
            Console.WriteLine("幅{0}、高さ{1}の四角形の面積は{2}", b.Width, b.Height, b.Area);
            Console.WriteLine("幅{0}、高さ{1}の三角形の面積は{2}", t.Width, t.Height, t.Area);
        }
    }
}