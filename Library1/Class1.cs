using NuGet.Versioning;

namespace Library1
{
    public class VersioningUtility
    {
        public static string GetPrereleaseLabel(string versionRange)
        {
            if (NuGetVersion.TryParse(versionRange, out NuGetVersion version))
            {
                return version.IsPrerelease ? version.Release : null;
            }
            return null;
        }
    }
}
