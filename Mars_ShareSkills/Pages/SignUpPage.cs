using Mars_ShareSkills.Excel_Data_reader;
using Mars_ShareSkills.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_ShareSkills.Pages
{
    public class SignUpPage : CommonDriver
    {
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Join')]")]
        public IWebElement joinButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[1]/form[1]/div[1]/input[1]")]
        public IWebElement firstNamebox { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[1]/form[1]/div[2]/input[1]")]
        public IWebElement lastNamebox { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email address']")]
        public IWebElement emailId { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[1]/form[1]/div[4]/input[1]")]
        public IWebElement passwordButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[1]/form[1]/div[5]/input[1]")]
        public IWebElement passwordConfirm { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[1]/form[1]/div[6]/div[1]/div[1]/input[1]")]
        public IWebElement agreeTerms { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='submit-btn']")]
        public IWebElement submitButton { get; set; }
        
        public void SignUp(IWebDriver driver)
        {


            PageFactory.InitElements(driver, this);
            ExcelReader.ReadDataTable(stream, "Signup");
            joinButton.Click();

            firstNamebox.Click();
            string firstName = ExcelReader.ReadData(1, "FirstName");
            firstNamebox.SendKeys(firstName);
            string lastName = ExcelReader.ReadData(1, "LastName");
            lastNamebox.SendKeys("Burra");

            emailId.Click();
            string emailAddress = ExcelReader.ReadData(1, "EmailId");
            emailId.SendKeys(emailAddress);

            passwordButton.Click();

            string passWord = ExcelReader.ReadData(1, "Password");
            passwordButton.SendKeys(passWord);

            passwordConfirm.Click();

            string passWordConfirm = ExcelReader.ReadData(1, "Confirmpassword");
            passwordConfirm.SendKeys(passWordConfirm);
            agreeTerms.Click();
            submitButton.Click();

        }

        }
    }
