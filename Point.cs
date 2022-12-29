using System;
namespace RightFigures
{
    public class Point
    {
        private double _x;
        private double _y;
        public double x
        {
            get
            { return _x; }
            set
            { _x = value; }
        }
        public double y
        {
            get { return _y; }
            set {_y=value; }
        }
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public override string ToString()
        {
            return $"Координаты(X;Y) - ({_x};{_y})";
        }
    }
}

