using DotNetFiddlerTestFramework.Pages;
using NUnit.Framework;


namespace DotNetFiddlerTestFramework.Tests
{
    [SetUpFixture]
    public class EditorPageTestBase:TestBase
    {
        protected EditorPage editorPage;
       

       [SetUp]
        public void Setup()
        {
            editorPage = new EditorPage();
            editorPage.Open();
        }

        [TearDown]
        public void Teardown()
        {
            editorPage.Close();
        }
    }
}
