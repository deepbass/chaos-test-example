using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace chaos_tester
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            IWebDriver driverOne = new ChromeDriver();
            driverOne.Navigate().GoToUrl("file:///Users/DanBass/dev/git/chaos-testing-csharp/src/static-website/index.html");
            IWebElement element = driverOne.FindElement(By.Id("button"));
            element.Click();
            WebDriverWait wait = new WebDriverWait(driverOne, TimeSpan.FromSeconds(2));
            IWebElement helloWorld = wait.Until(x => x.FindElement(By.Id("title")));
            string helloWorldString = helloWorld.Text;
            Assert.AreEqual("Hello World", helloWorldString);
        }
    }
}