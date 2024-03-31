using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;

namespace Kuku.Pages
{
    class ContactUsPage : Page
    {
        public ContactUsPage(IWebDriver driver)
        {
            Driver = driver;
        }

        protected override string PageUrl => "https://kuku.mk/contacts";
        protected override string PageTitle => "Contact Us | Kuku Куку";
        public void LoadingContactUsPage()
        {
            Driver.Navigate().GoToUrl(PageUrl);
            NavigateTo();
        }
        public void EnterName()
        {
            IWebElement NameInput = Driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div[2]/div/div/form/div[1]/input"));
            DemoHelper.Pause();
            NameInput.Click();

            IJavaScriptExecutor jsName = (IJavaScriptExecutor)Driver;
            jsName.ExecuteScript("arguments[0].value = '';", NameInput);
            NameInput.SendKeys("Ivona");
            DemoHelper.Pause();
        }
        public void EnterEmail()
        {
            IWebElement EmailInput = Driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div[2]/div/div/form/div[2]/input"));
            DemoHelper.Pause();
            EmailInput.Click();

            IJavaScriptExecutor jsName = (IJavaScriptExecutor)Driver;
            jsName.ExecuteScript("arguments[0].value = '';", EmailInput);
            EmailInput.SendKeys("ivona.nikoloska@yahoo.com");
            DemoHelper.Pause();
        }
        public void EnterSubject()

        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0, 1000);");

            IWebElement SubjectInput = Driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div[2]/div/div/form/div[3]/input"));
            DemoHelper.Pause();
            SubjectInput.Click();
            
            IJavaScriptExecutor jsName = (IJavaScriptExecutor)Driver;
            jsName.ExecuteScript("arguments[0].value = '';", SubjectInput);
            SubjectInput.SendKeys("Прашање");
            DemoHelper.Pause();
        }
        public void EnterMessage()
        {
            IWebElement MessageInput = Driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div[2]/div/div/form/div[4]/textarea"));
            DemoHelper.Pause();
            MessageInput.Click();

            IJavaScriptExecutor jsName = (IJavaScriptExecutor)Driver;
            jsName.ExecuteScript("arguments[0].value = '';", MessageInput);
            MessageInput.SendKeys("Извинете, само ја тестирам страната! :)");
            DemoHelper.Pause();
        }
        public void ClickNotRobot()
        {
            IWebElement element = Driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div[2]/div/div/form/div[5]/script[1]"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", element);
            //IWebElement element = Driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div[2]/div/div/form/div[6]/button"));
           
        }
        public void ClickSend()
        {
            IWebElement element = Driver.FindElement(By.XPath("//*[@id=\"rc-anchor-alert\"]"));
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", element);
            
            //IWebElement element = Driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div/div[2]/div/div/form/div[6]/button"));
            if (element.Displayed && element.Enabled)
            {
                element.Click();
            }
            else
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
                js.ExecuteScript("window.scrollBy(0, 1000);");
            }
        }
    }
}
