using System;

namespace JohnRodAreaCalculate
{
    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentOutOfRangeException("The radius cannot be negative.");
            Radius = radius;
        }

        protected sealed override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
