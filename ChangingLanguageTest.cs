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

    public class ChangingLanguageTest : IClassFixture<WebDriverFixture>
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage loginPage;

        public ChangingLanguageTest(WebDriverFixture fixture)
        {
            _driver = fixture.Driver;
            loginPage = new LoginPage(_driver);

        }
        #region EnglishLanguageTest
        [Fact]
        public void LanguageTest()
        {
            var loginPage = new LoginPage(_driver);
            loginPage.LoadingPage();
            DemoHelper.Pause();
           
            loginPage.English();
            DemoHelper.Pause();
            loginPage.DoubleClickEnglish();
            DemoHelper.Pause();
            Assert.Contains("https://kuku.mk/?lang=en_gb", _driver.Url);

        }
        #endregion
        #region MacedonianLanguageTest
        [Fact]
        public void LanguageTest2()
        {
            var loginPage = new LoginPage(_driver);
            loginPage.LoadingPage();
            DemoHelper.Pause();

            loginPage.English();
            DemoHelper.Pause();
            loginPage.DoubleClickMacedonian();
            DemoHelper.Pause();
            Assert.Contains("https://kuku.mk/?lang=mk_mk", _driver.Url);

        }
        #endregion
    }
}