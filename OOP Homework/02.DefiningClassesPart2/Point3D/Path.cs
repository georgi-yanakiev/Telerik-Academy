// 04. Create a class Path to hold a sequence of points in the 3D space.

namespace Point3D
{
    using System.Collections.Generic;

    class Path
    {
        private readonly List<Point3D> points = new List<Point3D>();
        public Path(params Point3D[] points)
        {
            this.Add(points);
        }

        public Path Add(params Point3D[] points)
        {
            foreach (Point3D point in points)
                this.points.Add(point);

            return this;
        }

        public override string ToString()
        {
            return string.Join(", ", points);
        }
    }
}