using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTest.Pages
{
    public class TMpage
    {
        public void CreateTM(IWebDriver driver)
        {
            IWebElement createnew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createnew.Click();
            IWebElement Typecode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
            Typecode.Click();
            Thread.Sleep(500);
            IWebElement SelectTime = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            SelectTime.Click();
            IWebElement enterCode = driver.FindElement(By.Id("Code"));
            enterCode.SendKeys("September");
            IWebElement DescriptionBox = driver.FindElement(By.Id("Description"));
            DescriptionBox.SendKeys("sony is good girl");
            IWebElement inputBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            inputBox.Click();
            IWebElement PriceUnitBox = driver.FindElement(By.Id("Price"));
            PriceUnitBox.SendKeys("$6000");
            IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
            SaveButton.Click();
            Thread.Sleep(2000);
            IWebElement goTOLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goTOLastPage.Click();
            Thread.Sleep(2000);

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            
            if (newCode.Text == "September")
            {
                Console.WriteLine("new record created successfully");
            }
            else
            {
                Console.WriteLine("new record is not created");
            }

            
          


        }
    }
}
