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
    public class ProfilePage 
    {
        public void AddName(IWebDriver driver)
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
        public void GetName(IWebDriver driver)
        {
            IWebElement Title = driver.FindElement(By.ClassName("title"));
            Assert.That(Title.Text == "Suneha Burra", "Name has not been added");
         
        }


        //Adding Availability to the profile page
        public void AddAvailability(IWebDriver driver)
        {
            Thread.Sleep(1000);
            IWebElement availabilityIcon = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i"));
            availabilityIcon.Click();

            IWebElement availabilityType = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select"));
            availabilityType.Click();

            IWebElement SelectFullTime = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[3]"));
            SelectFullTime.Click();
        }

        public string GetAvailabilityType(IWebDriver driver)
        {
            Thread.Sleep(500);
            IWebElement UpdatedAvail = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span"));
            return UpdatedAvail.Text;
            
        }
        //Adding hours to profile page
        public void AddHours(IWebDriver driver)
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
        public string GetHours(IWebDriver driver)
        {
            IWebElement NewHours = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span"));
            return NewHours.Text;

        }

        //Adding Description to the TextBox in profile page.
        public void AddDescription(IWebDriver driver)
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

        //Checking description has added or not
        public void GetDescription(IWebDriver driver)
        {
            Thread.Sleep(500);
            IWebElement Description = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            Assert.That(Description.Text == "I am interested to learn new Technologies", "Description has not added");

        }

        //Adding Language
        public void AddLanguage(IWebDriver driver)
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
        public void GetLanguage(IWebDriver driver)
        {
            Thread.Sleep(500);

            IWebElement AddedLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]"));
            IWebElement LanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]"));
            Assert.That(AddedLanguage.Text == "Hindi", "Language has not been added");
            Assert.That(LanguageLevel.Text == "Basic", "Languagelevel has not added");
        }

        //Adding skills

        public void AddSkills(IWebDriver driver)
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
        //Checking new skill is added or not
        public void GetSkill(IWebDriver driver)
        {
            IWebElement newSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]"));
            IWebElement SkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]"));
            Assert.That(newSkill.Text == "Automation Testing", "skill has not added");
            Assert.That(SkillLevel.Text == "Beginner", "Skilllevel has not added");
        }

        //Adding Certification details to profile page
        public void AddCertifications(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
            IWebElement CTFTab = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")));
            CTFTab.Click();

            IWebElement addNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
            Thread.Sleep(500);
            addNew.Click();

            IWebElement EnterCertification = driver.FindElement(By.Name("certificationName"));
            EnterCertification.SendKeys("Test Analyst");
            Thread.Sleep(1000);

            IWebElement CertificationFrom = driver.FindElement(By.Name("certificationFrom"));
            CertificationFrom.SendKeys("MVP Studio");
            Thread.Sleep(100);

            IWebElement SelectYearDropdown = driver.FindElement(By.Name("certificationYear"));
            SelectYearDropdown.Click();

            IWebElement SelectYearFromOptions = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select/option[2]"));
           
            SelectYearFromOptions.Click();

            IWebElement ClickAddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
            ClickAddButton.Click();
        }

        //Checking the skill is added in profile page or not
        public void GetCertificationDetails(IWebDriver driver)
        {
            Thread.Sleep(500);
            IWebElement CheckAwards = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[1]"));
            Assert.That(CheckAwards.Text == "Test Analyst", "Certification is not added");

            IWebElement CheckAwardsFrom = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
             Assert.That(CheckAwardsFrom.Text == "MVP Studio", "data has not added");

            IWebElement CheckYear = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
            Assert.That(CheckYear.Text == "2022", "year has not added");

        }



        }





            }
    





    








        












    

    

