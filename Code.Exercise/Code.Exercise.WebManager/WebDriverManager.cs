﻿using Code.Exercise.Helper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Code.Exercise.WebManager
{
    /// <summary>
    /// Singleton class to Manage web driver.
    /// </summary>
    public sealed class WebDriverManager
    {
        private WebDriverManager()
        { }

        private static WebDriverManager instance;
        private IWebDriver webDriver;

        /// <summary>
        /// Gets WebDriverManager Instance.
        /// </summary>
        public static WebDriverManager Instance
        {
            get => instance = instance ??= new WebDriverManager();
        }

        /// <summary>
        /// Starts, Open, navigate to Url and Maximize browser.
        /// </summary>
        /// <param name="url">Url to navigate.</param>
        public void Start(string url)
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl(url);
            webDriver.Manage().Window.Maximize();
        }

        /// <summary>
        /// Gets WebDriver instance.
        /// </summary>
        public IWebDriver WebDriver
        {
            get { return webDriver; }
        }

        /// <summary>
        /// Closes the web driver.
        /// </summary>
        public void Close()
        {
            webDriver.Close();
            webDriver.Quit();
        }
    }
}
