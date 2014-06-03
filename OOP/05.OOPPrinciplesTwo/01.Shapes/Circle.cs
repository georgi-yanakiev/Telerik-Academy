namespace Shapes
{
    using System;

    public class Circle : Shape
    {
        // circle constructor
        public Circle(double radius) : base(radius, radius)
        {
        }


        // Circle surface calculation
        // overriding the CalculateSurface method
        public override double CalculateSurface()
        {
            if (this.Height <= 0)
            {
                throw new ArgumentOutOfRangeException("Radius should be positive number!");
            }
            return Math.PI * Height * Width;
        }
    }
}