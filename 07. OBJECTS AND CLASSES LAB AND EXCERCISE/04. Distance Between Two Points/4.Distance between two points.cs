using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }

        public static double CalcDistance(Point p1, Point p2)
        {
            var a = p1.Y - p2.Y;
            var b = p2.X - p2.Y;
            return Math.Sqrt(a * a + b * b);
        }
        public static Point ReadPoint()
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var p = new Point() { X = input[0], Y = input[1] };
            return p;
        }
        public override string ToString()
        {
            return string.Format($"{Name} ({X},{Y})");
        }
    }


class Program
    {

    static void Main(string[] args)
    {
        Point p1 = Point.ReadPoint();
        Point p2 = Point.ReadPoint();
        var distance = Point.CalcDistance(p1, p2);
        Console.WriteLine($"{distance:f3}");
    }
        
}
