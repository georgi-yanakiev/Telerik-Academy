// 03. Write a static class with a static method to calculate the distance between two points in the 3D space.

namespace Point3D
{
    using System;

    static class Distance
    {
        public static double CalcDistance(Point3D first, Point3D second)
        {
            return Math.Sqrt(Math.Pow((first.X - second.X), 2) + Math.Pow((first.Y - second.Y), 2) + Math.Pow((first.Z - second.Z), 2));
        }
    }
}