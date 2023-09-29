using FluentAssertions;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnitFramework.Core.Consts;
using NUnitFramework.Pages;
using OpenQA.Selenium.Support.UI;

namespace NUnitFramework.Tests
{
    [TestFixture]
    [AllureNUnit]
    [AllureSuite("Login Feature")]
    [AllureFeature("Login Feature")]
    public class LoginTest : BaseTest
    {
        LoginPage loginPage;

        public LoginTest() : base()
        {
            loginPage = new(Driver);
        }

        [Test(Description = "Login with vaild user")]
        [AllureStory("Login with vaild user")]
        [AllureStep("Login with vaild user")]
        public void LoginWithVaildUser()
        {
            /*loginPage.InputAccount(TestData.VaildUser);
            loginPage.ClickLogin();
            MainPage mainPage = new MainPage(Driver);
            mainPage.IsTitleDisplayed.Should().BeTrue();*/

            loginPage.InputAccount(TestData.VaildUser);
            if (loginPage.background_color == loginPage.expectedColor)
            {
                loginPage.ClickLogin();
            }
            else
            {
                Console.WriteLine(loginPage.background_color);
            }
            MainPage mainPage = new MainPage(Driver);
            mainPage.IsTitleDisplayed.Should().BeTrue();
        }
    }
}
