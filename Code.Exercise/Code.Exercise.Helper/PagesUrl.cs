using System.Collections.Generic;

namespace Code.Exercise.Helper
{
    /// <summary>
    /// Handles Urls.
    /// </summary>
    public static class Urls
    {
        private static Dictionary<string, string> urls = new Dictionary<string, string>
        {
            { "Index", "http://automationpractice.com/index.php" }
        };

        /// <summary>
        /// Gets Urls from a keyword.
        /// </summary>
        /// <param name="key">Key to get url.</param>
        /// <returns>Url of a page.</returns>
        public static string GetUrl(string key)
        {
            return urls[key];
        }
    }
}
