using System.Threading.Channels;
using AreaLibrary;

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(5);
        Shape triangle = new Triangle(3, 4, 5);
        
        Console.WriteLine($"Площадь круга: {circle.AreaCalculate()}");
        Console.WriteLine($"Площадь треугольника: {triangle.AreaCalculate()}");
        
        if (triangle is Triangle tri)
        {
            bool isRightTriangle = tri.IsRightTriangle();
            Console.WriteLine($"Является ли треугольник прямоугольным? {isRightTriangle}");
        }
        else
        {
            Console.WriteLine("Фигура не является прямоугольным треугольником");
        }
        
    }
}