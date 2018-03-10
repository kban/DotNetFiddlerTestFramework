using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace DotNetFiddlerTestFramework
{
   [SetUpFixture]
    public class TestBase
    {

        [OneTimeSetUp]
        public void BeforeTestSuite()
        {
            Driver.DriverInstance.Manage().Window.Maximize();
            Driver.Wait = new WebDriverWait(Driver.DriverInstance, System.TimeSpan.FromSeconds(3));
        }
              
            

        [OneTimeTearDown]
        public void AfterTestSuite()
        {
           Driver.Close();
        }
    }
}

