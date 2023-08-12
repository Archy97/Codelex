using System;

struct Point
{
    public int x;
    public int y;

    public Point(int px, int py)
    {
        x = px;
        y = py;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(5, 2);
        Point p2 = new Point(-3, 6);

        SwapPoints(ref p1, ref p2);

        Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
        Console.WriteLine("(" + p2.x + ", " + p2.y + ")");
    }

    public static void SwapPoints<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
}
