using NUnitFramework.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TestFramework.WebDriver.Extensions;

namespace NUnitFramework.Pages
{
    public class LoginPage : BasePage
    {
        private IWebElement inputUsername => driver.GetElement("//input[@name = 'username']");
        private IWebElement inputPassword => driver.GetElement("//input[@name = 'password']");
        private IWebElement buttonLogin => driver.GetElement("//button[@type = 'submit']");
        public string background_color => buttonLogin.GetCssValue("background-color");
        public string expectedColor = "rgba(255, 123, 29, 1)";
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        public void InputUsername(string username)
        {
            inputUsername.SendKey(username);
        }

        public void InputPassword(string password)
        {
            inputPassword.SendKey(password);
        }

        public void InputAccount(UserModel user)
        {
            InputUsername(user.Username);
            InputPassword(user.Password);
        }

        public MainPage ClickLogin()
        {
            buttonLogin.Click();
            return new MainPage(driver);
        }
    }
}
