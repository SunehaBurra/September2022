using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Mars_ShareSkills.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_ShareSkills.Excel_Data_reader;
using WebDriverManager;

namespace Mars_ShareSkills.Utilities
{
    public class CommonDriver
    {

        public static IWebDriver driver;
        public static ExtentReports extentreportObj;
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentTest test;
        public static FileStream stream;

        [OneTimeSetUp]

        public void LoginFunctions()
        {

            //string fileName = @"C:\Users\RAM REDDY\First Project2022\September2022\Mars_ShareSkills\Excel Data reader\ExcelReaderDetails.xlsx";
            var htmlreporter = new ExtentHtmlReporter(@"C:\Users\RAM REDDY\First Project2022\September2022\Mars_ShareSkills\Extent Reports");

            extentreportObj = new ExtentReports();
            extentreportObj.AttachReporter(htmlreporter);

            //open chrome browser
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();







               if (loginCredentials.String1 == "sonysuneha@gmail.com")
               {
                   LoginPage loginObj = new LoginPage();
                   loginObj.LoginSteps(driver);
              }
              else
              {
                  SignUpPage signupObj = new SignUpPage();
                   signupObj.SignUp(driver);
               }
            string fileName = @"C:\Users\RAM REDDY\First Project2022\September2022\Mars_ShareSkills\Excel Data reader\ExcelReaderDetails.xlsx";
            //open file and returns as stream
            stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            ExcelReader.ReadDataTable(stream, "Skills");

        }
        public static void UseWait()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }



        [OneTimeTearDown]

        public void CloseTestRun()
        {
            extentreportObj.Flush();
            driver.Quit();
        }
    }
}



