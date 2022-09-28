using System;
using System.Collections.Generic;
using System.Text;

namespace ComputingArea
{
    public class Triangle : IFigure
    {
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Неверно указана длина.");

            if (   (sideA >= sideB + sideC)
                || (sideB >= sideA + sideC)
                || (sideC >= sideA + sideB))
                throw new ArgumentException("Cумма любых двух сторон должна быть больше третьей!");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            _isRightTriangle = new Lazy<bool>(GetIsRightTriangle);
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        private readonly Lazy<bool> _isRightTriangle;
        public bool IsRightTriangle => _isRightTriangle.Value;
        private bool GetIsRightTriangle()
        {
            if (   Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2)
                || Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2)
                || Math.Pow(SideC, 2) == Math.Pow(SideB, 2) + Math.Pow(SideA, 2))
                return true;
            else
                return false;
        }
        public double GetSquare()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
    }
}
