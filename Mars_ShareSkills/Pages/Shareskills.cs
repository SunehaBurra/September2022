using Mars_ShareSkills.Excel_Data_reader;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using Mars_ShareSkills.Utilities;

namespace Mars_ShareSkills.Pages
{
    public class Shareskills
    {
        //Identifying Title TextBox
        [FindsBy(How = How.Name, Using = "title")]
        public IWebElement TitleTextBox { get; set; }

        //Identifying Description Box
        [FindsBy(How = How.Name, Using = "description")]
        public IWebElement DescriptionBox { get; set; }

        //Identifying category
        [FindsBy(How = How.Name, Using = "categoryId")]
        public IWebElement CategoryDropdown { get; set; }

        //Selecting category 
        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[7]")]
        public IWebElement SelectOptions { get; set; }

        //Identifying subcategoryID
        [FindsBy(How = How.Name, Using = "subcategoryId")]
        public IWebElement subCategoryDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[5]")]
        public IWebElement SelectQA { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]
        public IWebElement TagsBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div/div/div/div/input")]
        public IWebElement NewTagBox { get; set; }

        //Select service type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        public IWebElement hourlyServiceType { get; set; }

        //Select One Off Service Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        public IWebElement oneOffServiceType { get; set; }

        //Select On-Site Location Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        public IWebElement onSiteLocation { get; set; }

        //Select Online Location Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        public IWebElement onlineLocation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        public IWebElement selectLocationType { get; set; }

        //Selecting start date
        [FindsBy(How = How.Name, Using = "startDate")]
        public IWebElement selectStartDate { get; set; }

        [FindsBy(How = How.Name, Using = "endDate")]
        public IWebElement SelectEndDate { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div[2]/div/div[3]/div[1]/div/input")]
        public IWebElement monday { get; set; }
        [FindsBy(How = How.Name, Using = "StartTime")]
        public IWebElement mondayStartTime { get; set; }
        [FindsBy(How = How.Name, Using = "EndTime")]
        public IWebElement mondayEndTime { get; set; }

        [FindsBy(How = How.Name, Using = "skillTrades")]
        public IWebElement selectSkillTrade { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        public IWebElement SkillTrade { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        public IWebElement workSample { get; set; }

        [FindsBy(How = How.Name, Using = "isActive")]
        public IWebElement selectOption { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]")]
        public IWebElement saveButton { get; set; }

        public void AddSkills(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);

            //Identify the title text Box and add the title
            string title = ExcelReader.ReadData(1, "Title");
            TitleTextBox.SendKeys(title);
            Thread.Sleep(2000);

            //Identify the description textBOx and add
            DescriptionBox.Click();
            string description = ExcelReader.ReadData(1, "Description");
            DescriptionBox.SendKeys(description);

            //Identify the category dropdown
            CategoryDropdown.Click();
            string category = ExcelReader.ReadData(1, "Category");

            //Identify the sub category and choose option
            subCategoryDropdown.Click();
            SelectElement selectSubcategory = new SelectElement(subCategoryDropdown);
            selectSubcategory.SelectByText(ExcelReader.ReadData(1, "SubCategory"));


            //Identify the tag textbox and enter
            TagsBox.Click();
            string tagName = ExcelReader.ReadData(1, "Tags");
            TagsBox.SendKeys(tagName);
            TagsBox.SendKeys(Keys.Enter);

            //Identify the new tag textbox and enter
            NewTagBox.Click();
            string newTagName = ExcelReader.ReadData(1, "New tag");
            NewTagBox.SendKeys(newTagName);

            //Select the service type option



            string serviceType = ExcelReader.ReadData(1, "ServiceType");
            if (serviceType.Equals("Hourly basis service"))
            {
                hourlyServiceType.Click();
            }
            else if (serviceType.Equals("One-off service"))
            {
                oneOffServiceType.Click();
            }
            //select location type
            selectLocationType.Click();
            string locationType = ((ExcelReader.ReadData(1, "LocationType")));
            if (locationType.Equals("On-site"))
            {
                onSiteLocation.Click();
            }
            else if (locationType.Equals("Online"))
            {
                onlineLocation.Click();
            }

            //Add start date for available days
            string startDateCol = ExcelReader.ReadData(1, "Start Date");
            selectStartDate.SendKeys(startDateCol);

            //Add end date for available days
            string endDate = ExcelReader.ReadData(1, "End date");
            SelectEndDate.SendKeys(endDate);

            //Select days
            monday.Click();

            // adding start time for monday
            mondayStartTime.Click();
            string startTime = ExcelReader.ReadData(1, "Start Time");
            mondayStartTime.SendKeys(startTime);

            //adding end time 
            mondayEndTime.Click();
            string endTime = ExcelReader.ReadData(1, "End Time");
            mondayEndTime.SendKeys(endTime);

            //selecting skill trade option
            selectSkillTrade.Click();

            //select skill exchange
            SkillTrade.Click();
            string skillExchange = ExcelReader.ReadData(1, "Skill Trade");
            SkillTrade.SendKeys(skillExchange);
            SkillTrade.SendKeys(Keys.Enter);

            //Uploading work sample
            workSample.Click();
            Thread.Sleep(2000);

            using (Process exeProcess = Process.Start(@"C:\Testing\sampletest\CompetitionTask1\CompetitionTask1\AutoIT\WorkSample.exe"))
            {
                exeProcess.WaitForExit();
            }

            selectOption.Click();
            CommonDriver.UseWait();

            saveButton.Click();
            CommonDriver.UseWait();

            IWebElement viewEditedSkills = driver.FindElement(By.XPath("//tbody/tr[1]/td[8]/div[1]/button[1]/i[1]"));
            viewEditedSkills.Click();

            IWebElement checkEditedTitle = driver.FindElement(By.XPath("//span[contains(text(),'Singer')]"));
            Assert.That(checkEditedTitle.Text == "Singer", "Expected Title and Edited Title doesnot match");
        }
    }
}

















    
