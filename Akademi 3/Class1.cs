using System;

abstract class Shape
{
	public abstract double CalculateArea();

	public abstract double CalculatePerimeter();
}

class Circle : Shape
{
	public double Radius { get; set; }

	public override double CalculateArea()
	{
		return Math.PI * Radius * Radius;
	}

	public override double CalculatePerimeter()
	{
		return 2 * Math.PI * Radius;
	}
}

class Rectangle : Shape
{
	public double Width { get; set; }
	public double Height { get; set; }

	public override double CalculateArea()
	{
		return Width * Height;
	}

	public override double CalculatePerimeter()
	{
		return 2 * (Width + Height);
	}
}

class Program
{
	static void Main(string[] args)
	{
		Shape circle = new Circle { Radius = 5 };
		Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
		Console.WriteLine($"Circle Perimeter: {circle.CalculatePerimeter()}");

		Shape rectangle = new Rectangle { Width = 4, Height = 6 };
		Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
		Console.WriteLine($"Rectangle Perimeter: {rectangle.CalculatePerimeter()}");
	}
}