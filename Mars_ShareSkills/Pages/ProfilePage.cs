using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using NUnit.Framework;
using System;
using System.Linq;
using System.Reflection.Metadata;
using OpenQA.Selenium.Support;
using Mars_ShareSkills.Utilities;

namespace Mars_ShareSkills.Pages
{
    public class ProfilePage
    {

        [FindsBy(How = How.XPath, Using = "//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a")]
        public IWebElement shareSkillsButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[3]")]
        public IWebElement managelistingButton { get; set; }

        public void GoToShareSkillPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            shareSkillsButton.Click();
            CommonDriver.UseWait();
        }
        public void GoToManageListingsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            managelistingButton.Click();
            CommonDriver.UseWait();


        }
    }
}
