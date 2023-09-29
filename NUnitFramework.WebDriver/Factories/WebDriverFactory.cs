using NUnitFramework.Core.Consts;
using NUnitFramework.WebDriver.Enums;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitFramework.WebDriver.Factories
{
    public static class WebDriverFactory
    {
        private static string driverPath = Path.Combine(Directory.GetCurrentDirectory(), "WebDrivers");
        public static IWebDriver OpenBrowser(DriverType driverType = DriverType.CHROME)
        {
            IWebDriver driver;
            switch (driverType)
            {
                case DriverType.CHROME:
                    ChromeOptions options = new ChromeOptions();
                    driver = new ChromeDriver(Path.Combine(driverPath, "ChromeDriver"), options);
                    Trace.WriteLine("In web Driver Factory");
                    break;
                case DriverType.FIREFOX:
                    driver = new FirefoxDriver(Path.Combine(driverPath, "FirefoxDriver"));
                    break;
                case DriverType.EDGE:
                    driver = new EdgeDriver(Path.Combine(driverPath, "EdgeDriver"));
                    break;
                default:
                    throw new ArgumentException("Can not find driver");
            }
            return driver;
        }
    }
}
