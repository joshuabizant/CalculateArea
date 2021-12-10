using System;
abstract class Shape
{
    public abstract double CalculateArea();

}

class Rectangle : Shape
{
    private double _side1;
    private double _side2;    
    public Rectangle(double side1, double side2)
    {
        _side1 = side1;
        _side2 = side2;
    }
    public override double CalculateArea()
    {
        double area = _side1 * _side2;
        return area;
    }
}

class Triangle : Shape
{
    private double _side1;
    private double _side2;
    private double _side3;

    public Triangle(double side1, double side2, double side3)
    {
        _side1 = side1;
        _side2 = side2;
        _side3 = side3;
    }

    public override double CalculateArea()
    {
        double area;
        double sides;

        sides = (_side1 + _side2 + _side3) / 2;

        area = (Math.Sqrt(sides * (sides - _side1) * (sides - _side2) * (sides - _side3)));
        return area;
    }

}

 class Circle : Shape
{
    double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double CalculateArea()
    {

        double area;

        area = Math.PI * (Math.Pow(_radius,2));
        return area;

    }

}

class App
{
    static void Main()
    {
        string figure;
        string state = "y";
        Console.WriteLine("Hello, I can calculate the Area of several geometric figures");
        while (state == "y")
        {
            Console.WriteLine("What figure do you wish to calculate. C=circle , T=triangle, R=rectangle");
            figure = Console.ReadLine();
            if (figure == "c" || figure == "C")
            {
                Circle circle = CreateCircle();
                double area = circle.CalculateArea();
                
                Console.WriteLine("the area of the Circle is {0} ", area);
            }
            else if (figure == "T" || figure == "t")
            {
                Triangle triangle = CreateTriangle();
                double area = triangle.CalculateArea();
                
                Console.WriteLine("the area of the Triangle is {0} ", area);

            }
            else if (figure == "r" || figure == "R")
            {
                Rectangle rectangle = CreateRectangle();
                double area = rectangle.CalculateArea();
                Console.WriteLine("the area of the Rectangle is {0} ", area);
            }
            else
            {
                Console.WriteLine("Please enter only the letter of the shape to calculate");
            }
            Console.WriteLine("Do you wish to continue calculating? y/n");
            state = Console.ReadLine();
        }
    }

    static Circle CreateCircle()
    {
        bool success = false;
        double r = 0;
        while (success != true)
        {
            Console.WriteLine("Please enter the Radius of your Circle");
            if (success = Double.TryParse(Console.ReadLine(), out r))
            {

            }
            else
            {
                Console.WriteLine("Please enter only numbers for your radius.");
            }
        }

        Circle circle = new Circle(r);
        return circle;

    }
    static Rectangle CreateRectangle()
    {

        double side1 = 0;
        double side2 = 0;
        bool success = false;

        while (success != true)
        {
            Console.WriteLine("Please enter the first side of your Rectangle");
            if (success = Double.TryParse(Console.ReadLine(), out side1))
            {

            }
            else
            {
                Console.WriteLine("Please enter only numbers for your side length.");
            }
        }
        success = false;
        while (success != true)
        {
            Console.WriteLine("Please enter the second side of your Rectangle");
            if (success = Double.TryParse(Console.ReadLine(), out side2))
            {

            }
            else
            {
                Console.WriteLine("Please enter only numbers for your side length.");
            }
        }        

        Rectangle rectangle = new Rectangle(side1, side2);

        return rectangle;

    }

    static Triangle CreateTriangle()
    {
        bool success = false;
        double side1 = 0;
        double side2 = 0;
        double side3 = 0;
        
              
        while (success != true)
        {
            Console.WriteLine("Please enter the first side of your Triangle");
            if (success = Double.TryParse(Console.ReadLine(), out side1))
            {
                
            }
            else
            {
                Console.WriteLine("Please enter only numbers for your side length.");
            }
        }
        success = false;
        while (success != true)
        {
            Console.WriteLine("Please enter the second side of your Triangle");
            if (success = Double.TryParse(Console.ReadLine(), out side2))
            {
                
            }
            else
            {
                Console.WriteLine("Please enter only numbers for your side length.");
            }
        }
        success = false;
        while (success != true)
        {
            Console.WriteLine("Please enter the third side of your Triangle");
            if (success = Double.TryParse(Console.ReadLine(), out side3))
            {

            }
            else
            {
                Console.WriteLine("Please enter only numbers for your side length.");
            }
        }

        Triangle triangle = new Triangle(side1, side2, side3);
        return triangle;

    }
}