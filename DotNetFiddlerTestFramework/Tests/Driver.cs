using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace DotNetFiddlerTestFramework
{
    public static class Driver
    {
        private static IWebDriver driverInstance;
        private static IWait<IWebDriver> wait;

        public static IWebDriver DriverInstance
        {
            get {
                if (driverInstance == null)
                {
                    var profile = new ChromeOptions();
                    profile.AddArguments("--ignore-certificate-errors");
                    profile.AddArguments("--ignore-ssl-errors");
                    driverInstance = new ChromeDriver(profile);
                }
                return driverInstance;
            }
        }

        public static IWait<IWebDriver> Wait { get ; set ; }

       
        public static void Close()
        {
            if (driverInstance != null)
            {
                driverInstance.Quit();
                driverInstance = null;
            }
        }
    }
        

    }
