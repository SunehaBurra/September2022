using Mars_Project.Drivers;
using Mars_Project.Utilities;
using Microsoft.VisualBasic.FileIO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Pages
{
    public class ProfilePage : Driver
    {
        //Method for Identifying firstname and last name ,and delete if any pre existing data is there.
        public void AddName()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            IWebElement DropdownIcon = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[1]/i")));
            DropdownIcon.Click();
            Thread.Sleep(1000);

            IWebElement firstName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[1]"));
            firstName.Clear();
            firstName.SendKeys("Suneha");
            IWebElement lastName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[1]/input[2]"));
            lastName.Clear();
            lastName.SendKeys("Burra");

            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[2]/div/div/div[2]/div/div[2]/button"));
            saveButton.Click();


        }

        //Method to verify if the given name details are visible on profile page
        public void GetName()
        {
            Thread.Sleep(200);
            IWebElement Title = driver.FindElement(By.ClassName("title"));
            //return Title.Text;
            Assert.That(Title.Text == "Suneha Burra", "Name has not been added");

        }


        //Adding Availability to the profile page
        public void AddAvailability()
        {
            Thread.Sleep(1000);
            IWebElement availabilityIcon = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            availabilityIcon.Click();

            IWebElement availabilityType = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
            availabilityType.Click();

            IWebElement SelectFullTime = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]"));
            SelectFullTime.Click();
        }

        //Method to check given Availability has added or not.

        public string GetAvailabilityType()
        {
            Thread.Sleep(500);
            IWebElement UpdatedAvail = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
            return UpdatedAvail.Text;

        }
        //Adding hours to profile page
        public void AddHours()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement SelectHours = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/span/i")));
            SelectHours.Click();

            IWebElement HoursDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i"));
            HoursDropDown.Click();

            IWebElement SelectedHours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select/option[3]"));
            SelectedHours.Click();
        }

        //checking hours added to profile page or not
        public string GetHours()
        {
            IWebElement NewHours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span"));
            return NewHours.Text;

        }

        //Adding Description to the TextBox in profile page.
        public void AddDescription()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement DescriptionIcon = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")));
            DescriptionIcon.Click();


            IWebElement AddText = driver.FindElement(By.Name("value"));
            AddText.Click();
            AddText.Clear();
            AddText.SendKeys("I am interested to learn new Technologies");

            IWebElement AddSaveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            AddSaveButton.Click();
        }

        //Method for Checking description has added or not
        public void GetDescription()
        {
            Thread.Sleep(500);
            IWebElement Description = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            Assert.That(Description.Text == "I am interested to learn new Technologies", "Description has not added");

        }

        //Adding Language 
        public void AddLanguage()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement LanguageTab = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")));
            LanguageTab.Click();

            IWebElement AddNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNew.Click();
            Thread.Sleep(1000);

            IWebElement TextBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            TextBox.Clear();
            TextBox.SendKeys("Hindi");

            IWebElement ChooseLevelDropDown = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            ChooseLevelDropDown.Click();
            Thread.Sleep(1000);

            IWebElement ChooseLevelOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]"));
            ChooseLevelOption.Click();
            Thread.Sleep(500);

            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            AddButton.Click();
            Thread.Sleep(1000);
        }

        //Method to check given language details are added or not.
        public void GetLanguage()
        {
            Thread.Sleep(500);

            IWebElement AddedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            IWebElement LanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            Assert.That(AddedLanguage.Text == "Hindi", "Language has not been added");
            Assert.That(LanguageLevel.Text == "Basic", "Languagelevel has not added");
        }

        //Method for Adding skills in Profile page

        public void AddSkills()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement SkillTab = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")));
            SkillTab.Click();

            IWebElement AddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddNewButton.Click();

            IWebElement AddSkillTextBox = driver.FindElement(By.Name("name"));

            AddSkillTextBox.SendKeys("Automation Testing");

            IWebElement ChooseSkillDropdown = driver.FindElement(By.Name("level"));
            ChooseSkillDropdown.Click();

            IWebElement SkillOption = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[2]"));
            SkillOption.Click();
            Thread.Sleep(500);

            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            AddButton.Click();
            Thread.Sleep(500);
        }
        //Method for Checking given skill details is added or not
        public void GetSkill()
        {
            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            IWebElement SkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            Assert.That(newSkill.Text == "Automation Testing", "skill has not added");
            Assert.That(SkillLevel.Text == "Beginner", "Skilllevel has not added");
        }

        //Adding Certification details to profile page
        public void AddCertifications(string Certificate, string Institute, string Year)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            IWebElement CTFTab = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")));
            CTFTab.Click();

            IWebElement addNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            Thread.Sleep(500);
            addNew.Click();

            IWebElement EnterCertification = driver.FindElement(By.Name("certificationName"));
            EnterCertification.SendKeys(Certificate);
            Thread.Sleep(1000);

            IWebElement CertificationFrom = driver.FindElement(By.Name("certificationFrom"));
            CertificationFrom.SendKeys(Institute);
            Thread.Sleep(100);

            IWebElement SelectYearDropdown = driver.FindElement(By.Name("certificationYear"));
            SelectYearDropdown.Click();

            SelectElement SelectYearFromOptions = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[2]"));

            SelectYearFromOptions.SelectByValue(Year);

            IWebElement ClickAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            ClickAddButton.Click();
        }

        //Checking the skill is added in profile page or not
        public void GetCertificationDetails(string Certificate, String Institute, string Year)
        {
            Thread.Sleep(500);
            IWebElement CheckAwards = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            Assert.That(CheckAwards.Text == Certificate, "Certification is not added");

            IWebElement CheckAwardsFrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
            Assert.That(CheckAwardsFrom.Text == Institute, "data has not added");

            IWebElement CheckYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
            Assert.That(CheckYear.Text == Year, "year has not added");

        }
    }
}

        //Adding Education Details to profile page
//        public void AddEducation(string Country, string institute, string degree, string title, string year)
//        {
//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
//            IWebElement EducationTab = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")));
//            EducationTab.Click();
//            TurnOnWait();

//            IWebElement AddNewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
//            TurnOnWait();
//            AddNewButton.Click();

//            SelectElement ChooseCountry = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select")));
//6           ChooseCountry.SelectByValue("Country");
//            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select/option[66]")).Click();

//            IWebElement InstituteName = driver.FindElement(By.Name("instituteName"));
//            InstituteName.SendKeys(institute);

//            IWebElement ChooseTitle = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
//            ChooseTitle.Click();
//            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select/option[7]")).Click();

//            IWebElement DegreeTextBox = driver.FindElement(By.Name("degree"));
//            DegreeTextBox.SendKeys("degree");

//            IWebElement YearDropDown = driver.FindElement(By.Name("yearOfGraduation"));
//            YearDropDown.Click();
//            Thread.Sleep(400);

//            SelectElement SelectYear = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select/option[8]")));
//            SelectYear.SelectByValue(year);

//            IWebElement AddDetails = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
//            AddDetails.Click();
//        }

//        //Method to check given details are added to Education Field//
//         public void GetEducation(string Country, string institute, string title, string degree, string year)
//        {
//            TurnOnWait();
            
//            IWebElement CountryName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]"));
//            IWebElement Institute = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[2]"));
//            IWebElement TitleBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[3]"));
//            IWebElement DegreeName = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[4]"));
//            IWebElement Year = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[5]"));

//            Assert.That(CountryName.Text == Country, "countryname has not been added");
//            Assert.That(Institute.Text == institute, "college name has not added");
//            Assert.That(TitleBox.Text == title, "title has not added to page");
//            Assert.That(DegreeName.Text == degree, "Degree has not added");
//            Assert.That(Year.Text == year, "year has not added");

//        }









        



        





        





    








        












    

    

