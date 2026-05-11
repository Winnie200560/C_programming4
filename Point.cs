using System;

internal class MyPoint
{
    private double _x;
    private double _y;

    public MyPoint()
    {
        _x = 0;
        _y = 0;
    }

    public MyPoint(double x, double y)
    {
        _x = x;
        _y = y;
    }

    public MyPoint(MyPoint other)
    {
        _x = other._x;
        _y = other._y;
    }

    public double X
    {
        get { return _x; }
        set { _x = value; }
    }

    public double Y
    {
        get { return _y; }
        set { _y = value; }
    }

    public double DistanceTo(MyPoint other)
    {
        double dx = other._x - _x;
        double dy = other._y - _y;

        return Math.Sqrt(dx * dx + dy * dy);
    }

    public static MyPoint operator ++(MyPoint p)
    {
        return new MyPoint(p._x + 1, p._y);
    }

    public static MyPoint operator --(MyPoint p)
    {
        return new MyPoint(p._x - 1, p._y);
    }

    public static explicit operator int(MyPoint p)
    {
        return (int)p._x;
    }

    public static implicit operator double(MyPoint p)
    {
        return p._y;
    }

    public static double operator +(MyPoint a, MyPoint b)
    {
        return a.DistanceTo(b);
    }

    public static MyPoint operator +(MyPoint p, int value)
    {
        return new MyPoint(p._x + value, p._y);
    }

    public static MyPoint operator +(int value, MyPoint p)
    {
        return new MyPoint(p._x + value, p._y);
    }

    public override string ToString()
    {
        return "Точка (" + _x + "; " + _y + ")";
    }
}