using Mars_Project.Pages;
using Mars_Project.Utilities;
using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;




namespace Mars_Project.StepDefinition
{
    [Binding]
    public class ProfileStepDefinitions : CommonDriver
    {
        LoginPage loginObj = new LoginPage();
        ProfilePage ProfileObj = new ProfilePage();

        [Given(@"I logged in QAMars Project successfully")]
        public void GivenILoggedInQAMarsProjectSuccessfully()
        {
            loginObj.Loginsteps(driver);
        }

        [When(@"I entered and save name")]
        public void WhenIEnteredAndSaveName()
        {
            ProfileObj.AddName(driver);
        }

        [Then(@"profile page should show the added name successfully\.")]
        public void ThenProfilePageShouldShowTheAddedNameSuccessfully()
        {
            ProfileObj.GetName(driver);
        }




        [When(@"I selected availability option")]
        public void WhenISelectedAvailabilityOption()
        {
            ProfileObj.AddAvailability(driver);
        }

        [Then(@"profile page should show the selected availability")]
        public void ThenProfilePageShouldShowTheSelectedAvailability()
        {
            ProfileObj.GetAvailabilityType(driver);
        }

        [When(@"I selected hours option")]
        public void WhenISelectedHoursOption()
        {
            ProfileObj.AddHours(driver);
        }

        [Then(@"profile page should display the selected hours")]
        public void ThenProfilePageShouldDisplayTheSelectedHours()
        {
            ProfileObj.GetHours(driver);
        }
        [When(@"I entered and saved description")]
        public void WhenIEnteredAndSavedDescription()
        {
            ProfileObj.AddDescription(driver);
        }

        [Then(@"profile page should show the added description")]
        public void ThenProfilePageShouldShowTheAddedDescription()
        {
            ProfileObj.GetDescription(driver);
        }



        [When(@"I entered and saved language")]
        public void WhenIEnteredAndSavedLanguage()
        {
            ProfileObj.AddLanguage(driver);
        }

        [Then(@"profile page should display the added language")]
        public void ThenProfilePageShouldDisplayTheAddedLanguage()
        {
            ProfileObj.GetLanguage(driver);
        }

        [When(@"I entered and save Skill")]
        public void WhenIEnteredAndSaveSkill()
        {
            ProfileObj.AddSkills(driver);
        }

        [Then(@"profile page should display added Skill")]
        public void ThenProfilePageShouldDisplayAddedSkill()
        {
            ProfileObj.GetSkill(driver);
        }

        [When(@"I entered certificate and year")]
        public void WhenIEnteredCertificateAndYear()
        {
            ProfileObj.AddCertifications(driver);
        }

        [Then(@"profile page should display added certification details")]
        public void ThenProfilePageShouldDisplayAddedCertificationDetails()
        {
            ProfileObj.GetCertificationDetails(driver);
        }
    }
}



        //[When(@"I added '([^']*)', issued '([^']*)' and slect option for '([^']*)' of certification in profile page")]
        //public void WhenIAddedIssuedAndSlectOptionForOfCertificationInProfilePage(string Certificate, string Institute, string Year)
        //{

        //    ProfileObj.AddCertifications(Certificate, Institute, Year);
        //}


        //[Then(@"the profile page should show the added '([^']*)', issued '([^']*)' along with selected  '([^']*)' of certificationon profile page\.")]
        //public void ThenTheProfilePageShouldShowTheAddedIssuedAlongWithSelectedOfCertificationonProfilePage_(string Certificate, string Institute, string Year)
        //{

        //    ProfileObj.GetCertificationDetails(Certificate, Institute, Year);
    //}
//}



