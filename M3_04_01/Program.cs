using System;

namespace BOOPM3_04_01
{
    class Program
    {
        //Base class or Parent class. 
        abstract public class Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }
        }

        // Triangle is derived from Shape.  
        public class Triangle : Shape
        {
            public double Area => Width * Height / 2;

            public override string ToString() => $"i am a {nameof(Triangle)} with area: {Area}";

        }
        // Rectangle is derived from Shape
        public class Rectangle : Shape
        {
            public double Area => Width * Height;
            public override string ToString() => $"i am a {nameof(Rectangle)} with area: {Area}";
        }

        public class Square : Rectangle{
            public double Width { get => base.Width; set { base.Width = value; base.Height = value; } }
            public double Height { get => base.Height; set{ base.Height = value; base.Width = value;} }

            public override string ToString() => $"i am a {nameof(Square)} with area: {Area}, side: {Width}";
        }

        static void Main(string[] args)
        {
            Triangle t1 = new Triangle() { Height = 100, Width = 200 };
            System.Console.WriteLine(t1);

            Rectangle r1 = new Rectangle() { Height = 100, Width = 200 };
            System.Console.WriteLine(r1);

            Square sq1 = new Square() { Height = 25};
            System.Console.WriteLine(sq1);
            Square sq2 = new Square() { Width = 50};
            System.Console.WriteLine(sq2);
        }
    }

    //Excercises:
    //1.    Create a derived class Circle, implement Area and Equals
    //2     Add property to all derived classes that calculate the circumference.
    //      Create instances of all derived classes and printout the circumferenance.
}
