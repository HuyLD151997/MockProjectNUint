using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestFramework.WebDriver.Extensions;

namespace NUnitFramework.Pages
{
    public class MainPage : BasePage
    {
        public bool IsTitleDisplayed => driver.IsElementDisplay(By.XPath("//span[@class='oxd-topbar-header-breadcrumb']/h6[text()='Dashboard']"));
        public MainPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
