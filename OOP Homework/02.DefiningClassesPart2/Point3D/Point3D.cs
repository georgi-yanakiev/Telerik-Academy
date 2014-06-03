// 01. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.

namespace Point3D
{
    using System;

    struct Point3D
    {
        public double X { get; private set; }

        public double Y { get; private set; }

        public double Z { get; private set; }

        private readonly static Point3D zero = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D Zero // static property returns point 0
        {
            get { return zero; }
        }

        public override string ToString() // printing a 3D point
        {
            return String.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
        }
    }
}