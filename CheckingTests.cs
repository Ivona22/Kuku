using Kuku.Kuku.UITest;
using Kuku.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Kuku
{
    public class CheckingTests : IClassFixture<WebDriverFixture>
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage loginPage;

        public CheckingTests(WebDriverFixture fixture)
        {
            _driver = fixture.Driver;
            loginPage = new LoginPage(_driver);

        }
        #region AboutTest
        [Fact]
        public void AboutTest()
        {
            var loginPage = new LoginPage(_driver);
            loginPage.LoadingPage();
            DemoHelper.Pause();

            loginPage.ClickAbout();
            DemoHelper.Pause();
            Assert.Contains("https://kuku.mk/static/about", _driver.Url);
        }
        #endregion
        #region TermsTest
        [Fact]
        public void TermTest()
        {
            var loginPage = new LoginPage(_driver);
            loginPage.LoadingPage();
            DemoHelper.Pause();

            loginPage.ClickTerms();
            DemoHelper.Pause();
            Assert.Contains("https://kuku.mk/static/terms", _driver.Url);
        }
        #endregion
        #region PrivacyTest
        [Fact]
        public void PrivacyTest()
        {
            var loginPage = new LoginPage(_driver);
            loginPage.LoadingPage();
            DemoHelper.Pause();

            loginPage.ClickPrivacy();
            DemoHelper.Pause();
            Assert.Contains("https://kuku.mk/static/privacy", _driver.Url);
        }
        #endregion
        #region MarketingTest
        [Fact]
        public void MarketingTest()
        {
            var loginPage = new LoginPage(_driver);
            loginPage.LoadingPage();
            DemoHelper.Pause();

            loginPage.ClickMarketing();
            DemoHelper.Pause();
            Assert.Contains("https://kuku.mk/static/marketing", _driver.Url);
        }
        #endregion
        #region ContactUsTest
        [Fact]
        public void ContactUsTest()
        {
            var loginPage = new LoginPage(_driver);
            loginPage.LoadingPage();
            DemoHelper.Pause();

            loginPage.ClickContactUs();
            DemoHelper.Pause();
            Assert.Contains("https://kuku.mk/contacts", _driver.Url);

        }
        #endregion
        #region EnterMessаge
        [Fact]
        public void EnerMessageTest()
        {
            var contactUsPage = new ContactUsPage(_driver);
            contactUsPage.LoadingContactUsPage();
            DemoHelper.Pause();

            contactUsPage.EnterName();
            contactUsPage.EnterEmail();
            contactUsPage.EnterSubject();
            contactUsPage.EnterMessage();
            contactUsPage.ClickNotRobot();
            DemoHelper.Pause();
            contactUsPage.ClickSend();
            DemoHelper.Pause();
            IWebElement MessageElement = _driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div[2]/div/div/form/div[7]"));

            string Message = MessageElement.Text;

            Assert.Equal("Your message has been sent! Thanks a lot and will be back to you soon", Message);
        }
            #endregion
            #region DirectoryTest
            [Fact]
             public void DirectoryTest()
        {
            var loginPage = new LoginPage(_driver);
            loginPage.LoadingPage();
            DemoHelper.Pause();

            loginPage.ClickDirectory();
            DemoHelper.Pause();
            Assert.Contains("https://kuku.mk/directory", _driver.Url);
        }
        #endregion
    }
}
