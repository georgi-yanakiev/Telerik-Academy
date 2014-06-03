namespace Point3D
{
    using System.IO;
    static class PathStorage
    {
        public static string LoadPath(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        public static void WritePath(Path path, string file)
        {
            File.WriteAllText(file, path.ToString());
        }
    }
}