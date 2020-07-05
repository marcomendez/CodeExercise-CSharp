using System.Collections.Generic;

namespace Code.Exercise.Helper
{
    public static class Urls
    {
        static Dictionary<string, string> urls = new Dictionary<string, string>
        {
            { "Index", "http://automationpractice.com/index.php" }
        };

        public static string GetUrl(string key)
        {
            return urls[key];
        }
    }
}
