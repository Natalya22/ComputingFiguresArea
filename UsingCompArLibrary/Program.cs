using ComputingArea;
using System;
using System.Collections.Generic;

namespace UsingCompArLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            AreaCalculator areaCalculator = new AreaCalculator(new List<IFigure>()
            {
                new Circle(3d),
                new Circle(4d),
                new Triangle(1d,2d,2d)
            });
            Console.WriteLine($"Sum of areas = {areaCalculator.SumOfAreas()}");
        }
    }
    public class AreaCalculator
    {
        private List<IFigure> _figures;

        public AreaCalculator(List<IFigure> figures)
        {
            _figures = figures;
        }

        public double SumOfAreas()
        {
            double sum = 0;
            foreach (var figure in _figures)
            {
                sum += figure.GetSquare();
            }
            return sum;
        }
    }
}
