using Library1;

using Library2;

using System;

namespace Console1
{
    class Program
    {
        static void Main()
        {
            var versionString = "1.0.0-prerelease";
            var frameworkName = "netstandard2.0";
            Console.WriteLine("Hello World!");
            Console.WriteLine("Calling into Library1");
            Console.WriteLine($"The prelease label for {versionString} is {VersioningUtility.GetPrereleaseLabel(versionString)}");
            Console.WriteLine("Calling into Library2");
            Console.WriteLine($"The framework name for {frameworkName} is {FrameworkUtility.GetCanonicalFrameworkName(frameworkName)}");
            Console.WriteLine("Done!");
        }
    }
}
