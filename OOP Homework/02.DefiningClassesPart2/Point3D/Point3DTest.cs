namespace Point3D
{
    using System;

    class Point3DTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Point3D(2, 5, 6)); // point test

            Console.WriteLine(Distance.CalcDistance(new Point3D(5, 6, 7), new Point3D(2, 1, 8))); // distance calculation test

            var path = new Path(new Point3D(1, 2, 3), new Point3D(4, 6, 8), new Point3D(9, 5, 3)); // path test
            Console.WriteLine(path);

            PathStorage.WritePath(path, "../../PathFile.txt"); // writing path to file
            Console.WriteLine("Reading path from file... \n{0}", PathStorage.LoadPath("../../PathFile.txt"));  // reading path from file
        }
    }
}