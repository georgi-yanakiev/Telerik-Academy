// testing version attribute

namespace VersionAttribute
{
    using System;

    [Version(2, 11)]
    class VersionAttributeTest
    {
        static void Main(string[] args)
        {
            Type type = typeof(VersionAttributeTest);

            object[] attributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute attribute in attributes)
            {
                Console.WriteLine("Testing attribute: {0}.{1}", attribute.major, attribute.minor); // printing of attributes
            }
        }
    }
}