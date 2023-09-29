using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitFramework.WebDriver.Factories
{
    public abstract class WebDriverManager
    {
        IWebDriver? driver = null;
        public abstract IWebDriver GetDriver();
        public void QuitDriver()
        {
            driver?.Quit();
            driver = null;
        }
    }
}
