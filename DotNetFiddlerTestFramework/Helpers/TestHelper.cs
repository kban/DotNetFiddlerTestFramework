using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.IO;


namespace DotNetFiddlerTestFramework.Helpers
{
   public class TestHelper
    {
        public static void TakeScreenshot()
        {
            try
            {
                ((ITakesScreenshot)Driver.DriverInstance).GetScreenshot().SaveAsFile(CreateFilename(), ScreenshotImageFormat.Png);
            }
            catch (Exception ) { }
        }

        protected static string CreateFilename()
        {
                return Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
                       + TestContext.CurrentContext.Test.FullName 
                       + DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".png";

        }
    }
}
