using System.Configuration;

namespace Code.Exercise.Helper
{
    /// <summary>
    /// Handles Environment information.
    /// </summary>
    public class Env
    {
        public static string ImplicitWait = ConfigurationManager.AppSettings["ImplicitWait"];
    }
}
