using System;

namespace ComputingArea
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            if (radius < Constants.minLength)
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
