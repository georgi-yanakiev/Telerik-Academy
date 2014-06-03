// 11. Create a [Version] attribute that can be applied to structures,
// classes, interfaces, enumerations and methods and holds a version 
// in the format major.minor (e.g. 2.11). Apply the version attribute 
// to a sample class and display its version at runtime.

namespace VersionAttribute
{
    using System;
    public class VersionAttribute : Attribute
    {
        public int major { get; private set; }
        public int minor { get; private set; }

        public VersionAttribute(int major, int minor)
        {
            this.major = major;
            this.minor = minor;
        }
    }
}