﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Firefox;
using CompetitionTask1.Screenshots;
using System.Text;
using NUnit.Framework;
using CompetitionTask1.Pages;
using SeleniumExtras.PageObjects;
using CompetitionTask1.Tests;
using ExcelDataReader;
using AventStack.ExtentReports;
using CompetitionTask1.Input;
using OpenQA.Selenium.DevTools.V105.DOM;
using System.Security.Policy;

namespace CompetitionTask1.Utilities
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

            var htmlreporter = new ExtentHtmlReporter(@"C:\Users\RAM REDDY\First Project2022\September2022\CompetitionTask1\CompetitionTask1\ExtentReports");

            extentreportObj = new ExtentReports();
            extentreportObj.AttachReporter(htmlreporter);

          
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();

            
            if (LoginCredentials.String1 == "sonysuneha@gmail.com")
            {
                  LoginPage loginpageObj = new LoginPage();
                  loginpageObj.LoginSteps();
            }
            else
            {
                  SignUpPage signuppageObj = new SignUpPage();
                  signuppageObj.SignUpSteps();
            }

            string fileName = @"C:\Users\RAM REDDY\First Project2022\September2022\CompetitionTask1\CompetitionTask1\ExternalFiles\ShareSkills_TestData.xlsx";
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

