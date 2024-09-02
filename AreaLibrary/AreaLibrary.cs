namespace AreaLibrary;

public abstract class Shape 
{
    public abstract double AreaCalculate(); 
}

public class Circle : Shape  
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double AreaCalculate()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}

public class Triangle : Shape
{
    public double A { get;  }
    public double B { get;  }
    public double C { get;  }

    public Triangle(double a, double b, double c)
    {
        if (!IsTriangle(a, b, c))
        {
            throw new ArgumentException("Данная фигура не является треугольником ");
        }

        A = a;
        B = b;
        C = c;
    }

    public override double AreaCalculate()
    {
        double semiperimeter = (A + B + C) / 2;
        return Math.Sqrt(semiperimeter * (semiperimeter - A) * (semiperimeter - B) * (semiperimeter - C));
    }

    private bool IsTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
    
    public bool IsRightTriangle()
    {
        double[] sides = new double[] { A, B, C };
        Array.Sort(sides);
        return Math.Pow(sides[2], 2) == (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2)) ? true : false;
    }
    
    public static class AreaCalculator
    {
        public static double CalculateArea(Shape shape)
        {
            return shape.AreaCalculate();
        }
    }
    
}