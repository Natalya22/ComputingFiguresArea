using System;

namespace ComputingArea
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Неверно указан радиус круга.", nameof(radius));
            Radius = radius;
        }

        public double Radius { get; }

        public double GetSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
