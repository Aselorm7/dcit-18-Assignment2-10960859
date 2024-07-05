using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    // Abstract base class
    abstract class Shape
    {
        // Abstract method to be implemented in derived classes
        public abstract double GetArea();
    }

    // Derived class for Circle
    class Circle : Shape
    {
        // Property to hold the radius of the circle
        public double Radius { get; set; }

        // Constructor to initialize the radius
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Override the GetArea method to calculate the area of a circle
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class for Rectangle
    class Rectangle : Shape
    {
        // Properties to hold the width and height of the rectangle
        public double Width { get; set; }
        public double Height { get; set; }

        // Constructor to initialize the width and height
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Override the GetArea method to calculate the area of a rectangle
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Circle with a radius of 5
            Circle myCircle = new Circle(5);

            // Create an instance of Rectangle with a width of 4 and height of 6
            Rectangle myRectangle = new Rectangle(4, 6);

            // Display the area of the circle
            Console.WriteLine($"Area of Circle: {myCircle.GetArea()}");

            // Display the area of the rectangle
            Console.WriteLine($"Area of Rectangle: {myRectangle.GetArea()}");
        }
    }
}

