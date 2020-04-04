using NuGet.Frameworks;

namespace Library2
{
    public class FrameworkUtility
    {
        public static string GetCanonicalFrameworkName(string shortFrameworkName)
        {
            if(shortFrameworkName == null)
            {
                return null;
            }
            var framework = NuGetFramework.Parse(shortFrameworkName);
            return framework.GetDotNetFrameworkName(DefaultFrameworkNameProvider.Instance);
        }
    }
}
