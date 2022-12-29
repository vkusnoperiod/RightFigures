using System;
namespace RightFigures
{
    public class Figure
    {
        private Point[] _points;
        public Point[] points
        {
            get
            {
                return _points;
            }   
            set
            {
                _points = value;
            }
        }
        protected double length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }
        public virtual double Area
        {
            get
            {
                return 5.6;
            }
        }
        public Figure()
        {
            
        }
    }
}

