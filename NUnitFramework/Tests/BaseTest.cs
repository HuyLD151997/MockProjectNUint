using NUnit.Allure.Core;
using NUnitFramework.WebDriver.Enums;
using NUnitFramework.WebDriver.Factories;
using OpenQA.Selenium;
using TestFramework.Core.Helpers;
using TestFramework.WebDriver.Extensions;

namespace NUnitFramework.Tests
{
    [TestFixture]
    [AllureNUnit]
    public class BaseTest: IDisposable
    {
        public IWebDriver Driver { get; set; }
       // public static TestContext TestContext { get; set; }

        public BaseTest()
        {
            InitBrower();
        }

        private void InitBrower()
        {
            // Open browser
            var browserText = ConfigurationHelper.GetValue<string>("browser").ToUpper();
            Enum.TryParse(browserText, out DriverType type);
            Driver = WebDriverFactory.OpenBrowser(type);

            // Set maximinize window
            Driver.Maximize();

            // Setting implicit wait
            var timeout = ConfigurationHelper.GetValue<int>("timeout");
            Driver.SetImplicitWait(timeout);

            // Go to test web page
            var url = ConfigurationHelper.GetValue<string>("url");
            Driver.Go(url);
        }

        public void Dispose()
        {
            Driver.Quit();
        }

    }
}
