using System;
using System.IO;
using System.Threading;
using Microsoft.AspNetCore.Cors.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace XUnitTest
{
    public class Tests : IDisposable
    {
        private readonly IWebDriver _driver;
        public Tests() => _driver = new ChromeDriver(Directory.GetCurrentDirectory());

        public void Dispose()
        {
            _driver.Quit();
            _driver.Close();
            _driver.Dispose();
        }

        [Fact]
        public void TestWithGoogleChrome()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElementByName("q").SendKeys("Poblacion de tlahualilo durango");
            Thread.Sleep(200);
            driver.FindElementByName("btnK").Click();
            Thread.Sleep(1000);
            driver.FindElementByClassName("yuRUbf").FindElement(By.TagName("a")).Click();
        }
    }
}
