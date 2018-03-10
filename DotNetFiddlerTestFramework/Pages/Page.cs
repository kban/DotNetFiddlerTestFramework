using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;


namespace DotNetFiddlerTestFramework.Pages
{
    public class Page
    {
        protected IWebDriver driver;
        public Page()
        {
             this.driver = Driver.DriverInstance;
        }

        public void Open(String url)
        {
            this.driver.Navigate().GoToUrl(url);
        }

        public void Close()
        {
            this.driver.Quit();

        }

    }
}
