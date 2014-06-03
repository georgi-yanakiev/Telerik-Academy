namespace Shapes
{
    using System;

    public class Rectangle : Shape
    {
        // rectangle constructor
        public Rectangle(double height, double width) : base(width, height)
        {
        }

        // Circle surface calculation
        // overriding the CalculateSurface method
        public override double CalculateSurface()
        {
            if (this.Width <= 0 || this.Height <= 0)
            {
                throw new ArgumentOutOfRangeException("Width and height should be bigger than zero!");
            }
            return this.Width * this.Height;
        }
    }
}