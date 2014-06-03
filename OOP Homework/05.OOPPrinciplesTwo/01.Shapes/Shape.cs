namespace Shapes
{
    using System;

    public abstract class Shape
    {
        // Shapes constructor
        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        // properties
        public double Height { get; private set; }

        public double Width { get; private set; }

        // abstract method for surface calculation
        public abstract double CalculateSurface();
    }
}