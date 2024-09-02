using AreaLibrary;

namespace AreaCalculator.Test;

public class Test
{
    [Test]
    public void CircleCalculateArea_OK()
    {
        double radius = 10;
        double RightArea = Math.PI * Math.Pow(radius, 2);

        var circle = new Circle(radius);
        double area = circle.AreaCalculate();
        
        Assert.AreEqual(RightArea, area);
    }
    
    [Test]
    public void TrianglelculateArea_OK()
    {
        double a = 3, b = 4, c = 5;
        double RightArea = 6;

        var triangle = new Triangle(a,b,c);
        double area = triangle.AreaCalculate();
        
        Assert.AreEqual(RightArea, area);
    }
    
    [Test]
    public void IsRightTriangle_OK()
    {
        var RightTriangle = new Triangle(3, 4, 5);

        bool IsRightTriangle = RightTriangle.IsRightTriangle();
        
        Assert.IsTrue(IsRightTriangle);
    }
    
    [Test]
    public void IsRightTriangle_False()
    {
        var RightTriangle = new Triangle(5, 5, 6);

        bool IsRightTriangle = RightTriangle.IsRightTriangle();
        
        Assert.IsFalse(IsRightTriangle);
    }
    [Test]
    public void NotTriangle_OK()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }
    
}