using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestFramework.WebDriver.Extensions
{
    public static class WebDriverExtension
    {
        public static IWebElement GetElement(this IWebDriver driver, string xpath)
        {
            return driver.GetElement(By.XPath(xpath));
        }

        public static IWebElement GetElement(this IWebDriver driver, By xpath)
        {
            return driver.FindElement(xpath);
        }

        public static string GetTitle(this IWebDriver driver)
        {
            return driver.Title;
        }

        public static bool IsElementDisplay(this IWebDriver driver, By xpath)
        {
            var timeSpan = driver.Manage().Timeouts().ImplicitWait;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

            try
            {
                return driver.FindElement(xpath).Displayed;
            }
            catch
            {
                return false;
            }
            finally
            {
                driver.Manage().Timeouts().ImplicitWait = timeSpan;
            }
        }

        public static string GetUrl(this IWebDriver driver)
        {
            return driver.Url;
        }

        public static void Maximize(this IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
        }

        public static void Go(this IWebDriver driver, string url)
        {
            if (url is null)
            {
                throw new ArgumentException("Invalid Url");
            }
            driver.Navigate().GoToUrl(url);
        }

        public static void SetImplicitWait(this IWebDriver driver, int timeout = 2)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
        }

        public static WebDriverWait SetExplicitWait(this IWebDriver driver, int timeout = 2)
        {
            return new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
        }
    }
}
