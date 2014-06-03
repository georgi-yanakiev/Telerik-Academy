namespace Shapes
{
    using System;

    public class Triangle : Shape
    {
        // triange constructor 
        public Triangle(double width, double height) : base(width,height)
        {
        }

        public override double CalculateSurface()
        {
            if (this.Width <= 0 || this.Height <= 0)
            {
                throw new ArgumentOutOfRangeException("Width and height should be bigger than zero!");
            }
            return (this.Width * this.Height) / 2;
        }
    }
}