using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuku.Pages
{
    public class LoginPage : Page
    {
        private readonly string validUsername;
        private readonly string validPassword;

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            validUsername = "ivona_22";
            validPassword = " Ivona12";



            ////public LoginPage(IWebDriver driver)
            ////{
            ////    Driver = driver;
        }

        protected override string PageUrl => "https://kuku.mk/";

        protected override string PageTitle => "Добредојдовте во KUKU";

        private IWebElement UsernameInput => Driver.FindElement(By.Name("username_email"));
        private IWebElement PasswordInput => Driver.FindElement(By.Name("password"));
        private IWebElement LoginButton => Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div[1]/div[1]/div[2]/form/div[4]/button"));

       
        //private IWebElement InvalidCredentilsText => Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/div/div[1]"));

        //private IWebElement ManuClick => Driver.FindElement(By.XPath("//li[@class='oxd-userdropdown' and @data-v-429cfcf3='' and @data-v-bdd6d943='' and @data-v-f0c5131f='']//i[@class='oxd-icon bi-caret-down-fill oxd-userdropdown-icon' and @data-v-bddebfba='' and @data-v-bdd6d943='']"));
        //private IWebElement LogoutButton => Driver.FindElement(By.XPath(" //a[@href='/web/index.php/auth/logout' and @role='menuitem' and contains(@class, 'oxd-userdropdown-link')]"));
        public void LoadingPage()
        {
            Driver.Navigate().GoToUrl(PageUrl);
            NavigateTo();
        }
        #region LogInTest
        public void EnterUsername(string username)
        {
            UsernameInput.SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            PasswordInput.SendKeys(password);
        }

        public void ClickLoginButton()
        {
            LoginButton.Click();
        }
        #endregion
        #region LogOutTest
        //public void DropdownManu()
        //{
        //    ManuClick.Click();
        //}

        //public void LogoutClick()
        //{
        //    LogoutButton.Click();
        //}
        #endregion
        public class EnsureLogIn
        {

            private readonly LoginPage loginPage;

            public EnsureLogIn(LoginPage loginPage)
            {
                //this.loginPage = loginPage;
                loginPage.NavigateTo();
                DemoHelper.Pause();
                DemoHelper.Pause();
                DemoHelper.Pause();
            }

            public void WithCredentials(string username, string password)
            {
                loginPage.EnterUsername("ivona_22");
                loginPage.EnterPassword("Ivona12");
                loginPage.ClickLoginButton();
                WithCredentials(loginPage.validUsername, loginPage.validPassword);



            }


        }
        #region LanguageTest
        public void English()
        {
            IWebElement element = Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div/div[1]/a"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", element);
           
        }
        public void DoubleClickEnglish()
        {
            IWebElement element = Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div/div[1]/div/div/a[1]"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", element);

        }
        public void DoubleClickMacedonian()
        {
            IWebElement element = Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div/div[1]/div/div/a[2]"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", element);

        }

        #endregion
        #region Checking
        public void ClickAbout()
        {
            IWebElement element = Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div/div[2]/a[1]"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", element);

        }
        public void ClickTerms()
        {
            IWebElement element = Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div/div[2]/a[2]"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", element);

        }
        public void ClickPrivacy()
        {
            IWebElement element = Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div/div[2]/a[3]"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", element);

        }
        public void ClickMarketing()
        {
            IWebElement element = Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div/div[2]/a[4]"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", element);

        }
        public void ClickContactUs()
        {
            IWebElement element = Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div/div[2]/a[5]"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", element);

        }
        public void ClickDirectory()
        {
            IWebElement element = Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div/div[2]/a[6]"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", element);

        }

        #endregion
       
    }
}