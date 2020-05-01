using System;
using System.Linq;

namespace JohnRodAreaCalculate
{
    public class Triangle : Shape
    {
        private readonly Lazy<bool> _isRightTriangle;
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
        public bool IsRightTriangle => _isRightTriangle.Value;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
                throw new ArgumentOutOfRangeException("The side of the Shape cannot be negative");

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            _isRightTriangle = new Lazy<bool>(CheckIsRightTriangle);
        }

        private bool CheckIsRightTriangle()
        {
            var maxSide = new[] { FirstSide, SecondSide, ThirdSide }.Max();
            var maxSideSqr = maxSide * maxSide;
            return maxSideSqr + maxSideSqr == FirstSide * FirstSide + SecondSide * SecondSide + ThirdSide * ThirdSide;
        }

        protected sealed override double CalculateArea()
        {
            var semiperimeterTriangle = (FirstSide + SecondSide + ThirdSide) / 2;
            var firstSideCoefficient = semiperimeterTriangle - FirstSide;
            var secondSideCoefficient = semiperimeterTriangle - SecondSide;
            var thirdSideCoefficient = semiperimeterTriangle - ThirdSide;
            return Math.Sqrt(semiperimeterTriangle * firstSideCoefficient * secondSideCoefficient * thirdSideCoefficient);
        }
    }
}
