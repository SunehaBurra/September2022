using AventStack.ExtentReports;
using Mars_ShareSkills.Excel_Data_reader;
using Mars_ShareSkills.Pages;
using Mars_ShareSkills.Screenshots;
using Mars_ShareSkills.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mars_ShareSkills.Tests
{
    [TestFixture]
    public class ShareskillsTest : CommonDriver
    {
        ProfilePage profilepageObj = new ProfilePage();
        Shareskills shareskillpageObj = new Shareskills();
        ListingsPage managelistingspageObj = new ListingsPage();

        public void CreateShareSkillTest()
        {


            test = extentreportObj.CreateTest("CreateSkills", "Testing Create Skills");
            profilepageObj.GoToShareSkillPage(driver);
            shareskillpageObj.AddSkills(driver);
            PageFactory.InitElements(driver, this);
            CommonDriver.UseWait();
            TakeScreenshot.ScreenShotMethod(driver);
            test.Log(Status.Info, "Skills created successfully");
            test.Log(Status.Pass, "Test passed");

        }


    }
    [Test, Order(2)]
    public void ViewShareskills()
        {
        try
        {

            test = extentreportObj.CreateTest("ViewSkills", "Testing Created Skills");
            profilepageObj.GoToManageListingsPage(driver);
            PageFactory.InitElements(driver, this);
            managelistingspageObj.viewSkills(driver);
            Thread.Sleep(2000);
            TakeScreenshot.ScreenShotMethod(driver);
            test.Log(Status.Info, "View Shareskills page opened successfully");
            test.Log(Status.Pass, "Test passed");
        }
        catch
        {
            test.Log(Status.Fail, "Test Failed");
        }
    }

    [Test, Order(3)]

    
    public void EditShareSkill()
    {
        test = extentreportObj.CreateTest("EditSkills", "Testing Created Skills");
        profilepageObj.NavigateManageListings(driver);
        managelistingspageObj.NavigateShareSkills(driver);
        shareskillpageObj.EditSkill(driver);
        CommonDriver.UseWait();
        TakeScreenshot.ScreenShotMethod(driver);
        test.Log(Status.Info, "Skills edited successfully");
        test.Log(Status.Pass, "Test passed");



    }
   

           
            [Test, Order(4)]
           
            

            public void DeleteSkillsTest()
            {
        try
        {

        
                test = extentreportobj.CreateTest("DeleteSkills", "Testing of delete page");
                ListingsPage deleteSkillsObj = new ListingsPage();
                deleteSkillsObj.DeleteShareSkill(driver);
                TakeScreenshot.ScreenShotMethod(driver);
                test.Log(Status.Info, "Skills deleted successfully");
                test.Log(Status.Pass, "test passed");
            }
        catch (Exception ex)
        {
            TakeScreenshot.ScreenShotMethod(driver);
            test.Log(Status.Fail, "Test Failed");
            Assert.Fail("Delete Skills Test failed", ex.Message);
            throw;
        }

    }
    }
}

