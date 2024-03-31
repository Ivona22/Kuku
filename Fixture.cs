using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuku
{
    
        namespace Kuku.UITest
        {
            public sealed class WebDriverFixture : IDisposable
            {
                public IWebDriver Driver { get; private set; }

                public WebDriverFixture()
                {
                    Driver = new ChromeDriver();
                }

                public void Dispose()
                {
                    Driver.Dispose();
                }
            }
        }
    }

