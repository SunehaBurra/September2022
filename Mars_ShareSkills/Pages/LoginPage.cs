
using SeleniumExtras.PageObjects;
using System.IO;
using OpenQA.Selenium;

using Mars_ShareSkills.Utilities;


namespace Mars_ShareSkills.Pages
{
    public class LoginPage : CommonDriver
    {
        //identify signin button and click on it
        [FindsBy(How = How.XPath, Using = "//a[@class='item']")]
        public IWebElement SignIn { get; set; }

        //identify username textbox and enter
        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement emailTextbox { get; set; }

        //identify password textbox and enter
        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement PasswordBox { get; set; }

        //identify login button and click on it
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        public IWebElement loginButton { get; set; }

        public void LoginSteps(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

            SignIn.Click();
            emailTextbox.SendKeys(LoginCredentials.String1);
            PasswordBox.SendKeys(LoginCredentials.String2);
            loginButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//a[contains(text(),'Share Skill')]", 10);
        }
    }
}

        
