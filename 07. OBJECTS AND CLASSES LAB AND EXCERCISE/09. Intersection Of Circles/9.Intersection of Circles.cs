using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    
    public static Point ReadPoints()
    {
        var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        var p1 = input[0];
        var p2 = input[1];
        Point points = new Point {X=p1,Y=p2 };
        return points;
    }

}
class Circle
{
   public Point Center { get; set; }
   public double Radius { get; set; }
    public static Circle ReadCircle()
    {
        var tokens = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        Circle myCircle = new Circle()
        {
            Center = new Point
            {
                X = tokens[0],
                Y = tokens[1]
            },
            Radius = tokens[2]
        };
        return myCircle;
    }
    public static double DistanceBetweenTwoPointsInCircle(Circle c1,Circle c2)
    {
        
        var a = c1.Center.X - c2.Center.Y;
        var b = c1.Center.Y - c2.Center.Y;
        var distance = Math.Sqrt(a*a + b*b);
        return distance;
    }

}
    class Program
    {
        static void Main(string[] args)
        {
        Circle firstCircle = Circle.ReadCircle();
        Circle secondCircle = Circle.ReadCircle();
        var distance = Circle.DistanceBetweenTwoPointsInCircle(firstCircle,secondCircle);
        var radiuses = firstCircle.Radius + secondCircle.Radius;

        if (distance < radiuses)
        { Console.WriteLine("yes"); }
        else
        { Console.WriteLine("no"); }
        }
    }

