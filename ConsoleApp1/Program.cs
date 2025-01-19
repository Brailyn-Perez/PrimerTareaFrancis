public class Program
{
    public static void Main()
    {
        Shape[] shapes = new Shape[]
        {
            new Rectangle(5, 10),
            new Triangle(4, 7),
            new Circle(3)
        };

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Área de {shape.GetType().Name}: {shape.CalculateSurface():F2}");
        }
    }
}

public abstract class Shape
{
    public double Ancho { get; set; }
    public double Alto { get; set; }

    protected Shape(double ancho, double alto)
    {
        Ancho = ancho;
        Alto = alto;
    }

    public abstract double CalculateSurface();
}

public class Rectangle : Shape
{
    public Rectangle(double ancho, double alto) : base(ancho, alto) { }

    public override double CalculateSurface()
    {
        return Ancho * Alto;
    }
}

public class Triangle : Shape
{
    public Triangle(double ancho, double alto) : base(ancho, alto) { }

    public override double CalculateSurface()
    {
        return (Ancho * Alto) / 2;
    }
}

public class Circle : Shape
{
    public Circle(double radio) : base(radio, radio) { }

    public override double CalculateSurface()
    {
        return Math.PI * Math.Pow(Ancho, 2); // Ancho se usa como radio
    }
}
