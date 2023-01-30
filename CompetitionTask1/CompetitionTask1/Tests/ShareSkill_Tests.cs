using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CompetitionTask1.Utilities;
using System.IO;
using AventStack.ExtentReports;
using CompetitionTask1.Input;
using CompetitionTask1.Pages;
using NUnit.Framework;
using CompetitionTask1.Screenshots;
using SeleniumExtras.PageObjects;
using ExcelDataReader;
using OpenQA.Selenium;

namespace CompetitionTask1.Tests
{
    [TestFixture]
    public class ShareSkill_Tests : CommonDriver
    {
       
        ProfilePage profilepageObj = new ProfilePage();
        ShareSkillPage shareskillpageObj = new ShareSkillPage();
        ManageListingsPage managelistingspageObj = new ManageListingsPage();



        [Test, Order(1)]


        public void CreateShareSkillTest()
        {
            try
            {

                test = extentreportObj.CreateTest("CreateSkills", "Testing Create Skills");
                PageFactory.InitElements(driver, this);
                profilepageObj.GoToShareSkillPage();
                shareskillpageObj.CreateShareSkill();
                shareskillpageObj.Category_Button();
                shareskillpageObj.Tag_Button();
                shareskillpageObj.Service_Button();
                shareskillpageObj.Location_Button();
                shareskillpageObj.Select_AvailableDays();
                shareskillpageObj.SkillExchange_Button();
                shareskillpageObj.Worksample_Button();
                shareskillpageObj.Active_Button();
                shareskillpageObj.Save_Button();
                CommonDriver.UseWait();
                TakeScreenShot.SSMethod(driver);
                test.Log(Status.Info, "Skills created successfully");
                test.Log(Status.Pass, "Test passed");

            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Test Failed");
                Assert.Fail("Create Skills Test Failed", ex.Message);
                throw;
            }
        }

        [Test, Order(2)]

        public void ViewShareSkillsTest()
        {
            try
            {

                test = extentreportObj.CreateTest("ViewSkills", "Testing Created Skills");
                profilepageObj.GoToManageListingsPage();
                PageFactory.InitElements(driver, this);
                managelistingspageObj.ViewListings();
                Thread.Sleep(2000);
                TakeScreenShot.SSMethod(driver);
                test.Log(Status.Info, "View Shareskills page opened successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Test Failed");
                Assert.Fail("view skills test failed", ex.Message);
                throw;
            
            }
        }

        [Test, Order(3)]
        public void EditShareSkillTest()
        {
            try
            {


                test = extentreportObj.CreateTest("EditSkills", "Testing Created Skills");
                PageFactory.InitElements(driver, this);
                profilepageObj.GoToManageListingsPage();
                managelistingspageObj.GoToShareSkillPage();
                shareskillpageObj.EditShareSkill();
                shareskillpageObj.Edit_Category();
                shareskillpageObj.Edit_SubCategory();
                shareskillpageObj.Edit_ServiceType();
                shareskillpageObj.Edit_Day();
                shareskillpageObj.Edit_SkillTrade();
                shareskillpageObj.Edit_WorkSample();
                shareskillpageObj.Edit_ActiveButton();
                shareskillpageObj.Edit_Save();
                CommonDriver.UseWait();
                TakeScreenShot.SSMethod(driver);
                test.Log(Status.Info, "Skills edited successfully");
                test.Log(Status.Pass, "Test passed");



            }
            catch (Exception ex)
            {
                test.Log(Status.Fail, "Test Failed");
                Assert.Fail("Edit skills test Failed", ex.Message);
                throw;
            }
        }

        [Test, Order(4)]

        public void DeleteShareSkillTest()
        {
            try
            {
                test = extentreportObj.CreateTest("DeleteSkills", "Deleting skills created");
                profilepageObj.GoToManageListingsPage();
                managelistingspageObj.DeleteShareSkill();
                CommonDriver.UseWait();
                TakeScreenShot.SSMethod(driver);
                test.Log(Status.Info, "Skill listing deleted successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch(Exception ex)
            {
               
                test.Log(Status.Fail, "Test Failed");
                Assert.Fail("Delete Skills Test failed", ex.Message);
                throw;
            }

        }

    }

} 
    



    

