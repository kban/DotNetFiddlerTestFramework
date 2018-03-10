using System;
using DotNetFiddlerTestFramework.Helpers;
using DotNetFiddlerTestFramework.Pages;
using DotNetFiddlerTestFramework.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace DotNetFiddlerTestFramework
{
    [TestFixture]
    public class EditorPageTests: EditorPageTestBase {

        [Test]
        public void TestLogoImage()
        {
            editorPage.LogoLink.Click();
            
        }
    }
}
