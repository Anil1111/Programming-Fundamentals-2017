using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Rectangle
{
    public double Top { get; set; }
    public double Left { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double Right
    {
        get
        {
            return Left + Right;
        }
    }
    public double Bottom
    {
        get
        {
            return Top + Height;
        }
    }

    public bool IsInside(Rectangle r2)
    {
        var isInside = false;
        if (
            Left >= r2.Left &&
            Right <= r2.Right &&
            Top >= r2.Top &&
            Bottom <= r2.Bottom
            )
        { return isInside = true; }
        else
        { return isInside = false; }

    }
    public static Rectangle ReadRectangle()
    {
        var tokens = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        var left = tokens[0];
        var top = tokens[1];
        var width = tokens[2];
        var height = tokens[3];
        Rectangle rect = new Rectangle() {Top = top, Left = left,Width = width, Height = height};
        return rect;
    }
}
    class Program
    {
        static void Main(string[] args)
        {
        Rectangle firstRect = Rectangle.ReadRectangle();
        Rectangle secondRectangle = Rectangle.ReadRectangle();
        var isInside = firstRect.IsInside(secondRectangle);
        Console.WriteLine(isInside);
        }
    }

