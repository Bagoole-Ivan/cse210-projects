using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace simpleCalculator
{

    /*Simple Calculator to calculate the perimeter and area of a Rectangle and a Triangle and some other shapes */

    /* Abstraction */
    abstract class Figure
    {
        abstract public Int32 Perimeter();
        abstract public Int32 Area();
    }

    /* Inheriting from the Figure class */
    class Rectangle : Figure
    {
        public Rectangle(Int32 w, Int32 h)
        {
            this.w = w;
            this.h = h;
        }

        /* Encapsulation */
        public Int32 w { get; set; }
        public Int32 h { get; set; }

        /* Polymorphism */
        public override Int32 Perimeter()
        {
            return 2 * w + 2 * h;
        }

        public override int Area()
        {
            return w * h;
        }
    }
        class Square : Figure
    {
        public Square(Int32 s)
        {
            this.s = s;
        }

        /* Encapsulation */
        public Int32 s { get; set; }

        /* Polymorphism */
        public override Int32 Perimeter()
        {
            return s * 4;
        }

        public override int Area()
        {
            return s * s;
        }
    }

    class irregularPentagon : Figure
    {
        public irregularPentagon(Int32 s1, Int32 s2, Int32 s3, Int32 s4, Int32 s5, Int32 s6, Int32 s7)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            this.s4 = s4;
            this.s5 = s5;
            this.s6 = s6;
            this.s7 = s7;
        }

        /* Encapsulation */
        public Int32 s1 { get; set; }
        public Int32 s2 { get; set; }
        public Int32 s3 { get; set; }
        public Int32 s4 { get; set; }
        public Int32 s5 { get; set; }
        public Int32 s6 { get; set; }
        public Int32 s7 { get; set; }

        /* Polymorphism */
        public override Int32 Perimeter()
        {
            return s1 + s2 +s3 + s4 + s5 + s6 + s7;
        }

        public override int Area()
        {
            throw new NotImplementedException();
        }
    }

    class Triangle : Figure
    {
        public Triangle(Int32 s1, Int32 s2, Int32 b, Int32 h)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.b = b;
            this.h = h;
        }

        public Int32 s1 { get; set; }
        public Int32 s2 { get; set; }
        public Int32 b { get; set; }
        public Int32 h { get; set; }

        public override Int32 Perimeter()
        {
            return s1 + s2 + b;
        }

        public override int Area()
        {
            return (1 / 2) * b * h ;
        }
    }

    class Polygon : Figure
    {
        /* This is a polygon with five equal sides */
        public Polygon(Int32 s1)
        {
            this.s1 = s1;
        }

        public Int32 s1 { get; set; }

        public override Int32 Perimeter()
        {
            return s1 * 5;
        }

        public override int Area()
        {
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Figure rectangle = new Rectangle(10, 23);
            Figure triangle = new Triangle(23, 11, 9, 10);
            Figure square = new Square(4);
            Figure polygon = new Polygon(5);
            Figure IrregularPentagon = new irregularPentagon(3, 6, 8, 9, 11, 13, 16);

            Int32 rectanglePerimeter = rectangle.Perimeter();
            Int32 trianglePerimeter = triangle.Perimeter();
            Int32 squarePerimeter = square.Perimeter();
            Int32 polygonPerimeter = polygon.Perimeter();
            Int32 IrregularPentagonPerimeter = IrregularPentagon.Perimeter();


            Int32 rectangleArea = rectangle.Area();
            Int32 triangleArea = triangle.Area();
            Int32 squareArea = square.Area();
            Int32 polygonArea = polygon.Area();
            Int32 IrregularPentagonArea = IrregularPentagon.Area();

            Console.WriteLine("Rectangle perimeter: " + rectanglePerimeter);
            Console.WriteLine("Triangle perimeter: " + trianglePerimeter);
            Console.WriteLine("Square perimeter: " + squarePerimeter);
            Console.WriteLine("Polygon perimeter: " + polygonPerimeter);
            Console.WriteLine("irregularPentagon perimeter" + IrregularPentagonPerimeter);


            Console.WriteLine("Rectangle area: " + rectangleArea);
            Console.WriteLine("Triangle area: " + triangleArea);
            Console.WriteLine("Square area: " + squareArea);

        }
    }
}