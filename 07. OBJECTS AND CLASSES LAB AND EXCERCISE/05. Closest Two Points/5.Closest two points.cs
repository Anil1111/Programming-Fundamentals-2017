using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public static Point ReadPoints()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var p = new Point() { X = input[0], Y = input[1] };
        return p;
    }

    public static double CalcDistance(Point p1, Point p2)
    {
        var a = p1.Y - p2.Y;
        var b = p1.X - p2.Y;
        var c = Math.Sqrt(a * a + b * b);
        return c;
    }

    public override string ToString()
    {
        return string.Format($"({X},{Y})");
    }

   

    internal static Point[] ReadArrayOfPoitn()
    {
        var n = int.Parse(Console.ReadLine());
        Point[] result = new Point[n];

        for (int i = 0; i < n; i++)
        {
            Point currentPoint = ReadPoints();
            result[i] = currentPoint;
        }
        return result;
    }

    internal static Point[] FindClosestTwoPoints(Point[] arrayOfPoints)
    {
        var minDistance = double.MaxValue;
        Point[] closestTwoPoints = null;

        for (int i = 0; i < arrayOfPoints.Length; i++)
        {
            for (int j = i+1; j < arrayOfPoints.Length - 1; j++)
            {
                var p1 = arrayOfPoints[i];
                var p2 = arrayOfPoints[j];
                double distance = CalcDistance(p1,p2);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestTwoPoints = new Point[] { p1, p2 };
                }
            }
        }
        return closestTwoPoints;
    }
}
    class Program
    {
        static void Main(string[] args)
        {

        Point[] input = Point.ReadArrayOfPoitn();
        var closestTwoPoints = Point.FindClosestTwoPoints(input);
        foreach (var item in closestTwoPoints)
        {
            Console.WriteLine($"{item.X}, {item.Y}");
            
        }

        }
    }

