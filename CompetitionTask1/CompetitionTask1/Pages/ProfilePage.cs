using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using CompetitionTask1.Utilities;
using SeleniumExtras.PageObjects;

namespace CompetitionTask1.Pages
{
    public class ProfilePage : CommonDriver 
    {
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        public IWebElement shareSkillbutton { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Listings')]")]
        public IWebElement manageListingsbutton { get; set; }

        public void GoToShareSkillPage()
        {
            PageFactory.InitElements(driver, this);
            shareSkillbutton.Click();
            CommonDriver.UseWait();
        }
        public void GoToManageListingsPage()
        {
            PageFactory.InitElements(driver, this);
            manageListingsbutton.Click();
            CommonDriver.UseWait();
        }

    }
}
