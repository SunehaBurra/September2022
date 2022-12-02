using Mars_Project.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Mars_Project.Drivers;

namespace Mars_Project.Pages
{
    public class LoginPage : Driver
    {
     
        //Method to login QAMars project
        public void Loginsteps()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            
            //Identify SignIn button

            IWebElement SignIn = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            SignIn.Click();

            //Adding username TextBox//
            IWebElement UsernameTextBox = driver.FindElement(By.Name("email"));
            UsernameTextBox.SendKeys("sonysuneha@gmail.com");
            

            //Adding Password TextBox//
            IWebElement PasswordField = driver.FindElement(By.Name("password"));
            PasswordField.Clear();
            PasswordField.SendKeys("Sunehareddy17");
            

            //Click on Login Button
            IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            LoginButton.Click();
            Thread.Sleep(500);

        }
        
        

        
    }
}
