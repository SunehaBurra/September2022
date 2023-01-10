using Mars_ShareSkills.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Mars_ShareSkills.Pages
{
    public class ListingsPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[1]/i")]
        public IWebElement viewListingsbutton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[2]/i")]
        public IWebElement editButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i")]
        public IWebElement deleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[3]/button[2]")]
        public IWebElement alertYes { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        public IWebElement deleteConfirm { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'ISTQB')]")]
        public IWebElement listedTitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'You do not have any service listings!')]")]
        public IWebElement deletedListing { get; set; }

        public void ViewListings(IWebDriver driver)
        {
            CommonDriver.UseWait();
            PageFactory.InitElements(driver, this);
            viewListingsbutton.Click();
            CommonDriver.UseWait();
            Assert.That(listedTitle.Text == "ISTQB", "Expected and actual Title doesnot match");
        }

        public void GoToShareSkillPage(IWebDriver driver)
        {
            CommonDriver.UseWait();
            PageFactory.InitElements(driver, this);
            editButton.Click();
            CommonDriver.UseWait();
        }

        public void DeleteShareSkill(IWebDriver driver)
        {
            CommonDriver.UseWait();
            PageFactory.InitElements(driver, this);
            deleteButton.Click();
            deleteConfirm.Click();
            CommonDriver.UseWait();
            Assert.That(deletedListing.Text == "You do not have any service listings!", "Record  not deleted");

        }

    }
}



