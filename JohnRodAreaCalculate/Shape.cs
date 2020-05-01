using System;

namespace JohnRodAreaCalculate
{
    public abstract class Shape
    {
        private readonly Lazy<double> _area;
        public double Area => _area.Value;
        protected Shape()
        {
            _area = new Lazy<double>(CalculateArea);
        }
        protected abstract double CalculateArea();
    }
}
