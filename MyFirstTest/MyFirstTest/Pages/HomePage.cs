using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTest.Pages
{
    public class HomePage
    {
        public void GoToHomepage(IWebDriver driver)
        {
            IWebElement administrationdropdownbox= driver.FindElement(By.XPath("/html / body / div[3] / div / div / ul / li[5] / a"));
            administrationdropdownbox.Click();
            Thread.Sleep(500);

            IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoption.Click();
        }
    }
}
