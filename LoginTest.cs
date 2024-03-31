using Kuku.Kuku.UITest;
using Kuku.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Kuku
{
    public class LoginTest : IClassFixture<WebDriverFixture>
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;

        public LoginTest(WebDriverFixture fixture)
        {
            _driver = fixture.Driver;
            _loginPage = new LoginPage(_driver);

        }
        #region SuccessfulLogin
        [Fact]
        public void SuccessfulLogin()
        {
            _loginPage.NavigateTo();
            DemoHelper.Pause();
            _loginPage.EnterUsername("ivona_22");
            DemoHelper.Pause();

            _loginPage.EnterPassword("Ivona12");
            DemoHelper.Pause();

            _loginPage.ClickLoginButton();
            DemoHelper.Pause();



            Assert.Equal("KUKU", _driver.Title);
        }
        #endregion
        #region UnsuccessfulLogin
        #region UnvalidPass
        [Fact]
        public void UnValidPass()
        {
            _loginPage.NavigateTo();
            DemoHelper.Pause();
            _loginPage.EnterUsername("ivona_22");
            DemoHelper.Pause();

            _loginPage.EnterPassword("Ivona123");
            DemoHelper.Pause();

            _loginPage.ClickLoginButton();
            DemoHelper.Pause();

            IWebElement errorMessageElement = _driver.FindElement(By.CssSelector(".alert.alert-danger"));

            string errorMessage = errorMessageElement.Text;

            Assert.Equal("Please re-enter your password, The password you entered is incorrect", errorMessage);


        }
        #endregion UnvalidPass
        #region UnvalidUsername
        [Fact]
        public void UnValidUsername()
        {
            _loginPage.NavigateTo();
            DemoHelper.Pause();
            _loginPage.EnterUsername("ivona_222");
            DemoHelper.Pause();

            _loginPage.EnterPassword("Ivona12");
            DemoHelper.Pause();

            _loginPage.ClickLoginButton();
            DemoHelper.Pause();

            IWebElement errorMessageElement = _driver.FindElement(By.CssSelector(".alert.alert-danger"));

            string errorMessage = errorMessageElement.Text;

            Assert.Equal("The username you entered does not belong to any account", errorMessage);


        }
        #endregion UnvalidUsername
        #endregion UnsuccessfullLogin
    }
}
