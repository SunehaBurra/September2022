using Mars_Project.Pages;
using Mars_Project.Utilities;
using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using Mars_Project.Drivers;




namespace Mars_Project.StepDefinition
{
    [Binding]
    public class ProfileStepDefinitions : Driver
    {
        LoginPage loginObj = new LoginPage();
        ProfilePage ProfileObj = new ProfilePage();

        [Given(@"I logged in QAMars Project successfully")]
        public void GivenILoggedInQAMarsProjectSuccessfully()
        {
            loginObj.Loginsteps();
        }

        [When(@"I entered and save name")]
        public void WhenIEnteredAndSaveName()
        {
            ProfileObj.AddName();
        }

        [Then(@"profile page should show the added name successfully\.")]
        public void ThenProfilePageShouldShowTheAddedNameSuccessfully()
        {
            ProfileObj.GetName();
        }




        [When(@"I selected availability option")]
        public void WhenISelectedAvailabilityOption()
        {
            ProfileObj.AddAvailability();
        }

        [Then(@"profile page should show the selected availability")]
        public void ThenProfilePageShouldShowTheSelectedAvailability()
        {
            ProfileObj.GetAvailabilityType();
        }

        [When(@"I selected hours option")]
        public void WhenISelectedHoursOption()
        {
            ProfileObj.AddHours();
        }

        [Then(@"profile page should display the selected hours")]
        public void ThenProfilePageShouldDisplayTheSelectedHours()
        {
            ProfileObj.GetHours();
        }
        [When(@"I entered and saved description")]
        public void WhenIEnteredAndSavedDescription()
        {
            ProfileObj.AddDescription();
        }

        [Then(@"profile page should show the added description")]
        public void ThenProfilePageShouldShowTheAddedDescription()
        {
            ProfileObj.GetDescription();
        }



        [When(@"I entered and saved language")]
        public void WhenIEnteredAndSavedLanguage()
        {
            ProfileObj.AddLanguage();
        }

        [Then(@"profile page should display the added language")]
        public void ThenProfilePageShouldDisplayTheAddedLanguage()
        {
            ProfileObj.GetLanguage();
        }

        [When(@"I entered and save Skill")]
        public void WhenIEnteredAndSaveSkill()
        {
            ProfileObj.AddSkills();
        }

        [Then(@"profile page should display added Skill")]
        public void ThenProfilePageShouldDisplayAddedSkill()
        {
            ProfileObj.GetSkill();
        }
        [When(@"I added '([^']*)', issued '([^']*)' and slect option for '([^']*)' of certification in profile page")]
        public void WhenIAddedIssuedAndSelectOptionForOfCertificationInProfilePage(string Certificate, string Institute, string Year)
        {

            ProfileObj.AddCertifications(Certificate, Institute, Year);
        }


        [Then(@"the profile page should show the added '([^']*)', issued '([^']*)' along with selected  '([^']*)' of certificationon profile page\.")]
        public void ThenTheProfilePageShouldShowTheAddedIssuedAlongWithSelectedOfCertificationonProfilePage_(string Certificate, string Institute, string Year)
        {

            ProfileObj.GetCertificationDetails(Certificate, Institute, Year);
        }
    }
}

//[When(@"I entered certificate and year")]
//public void WhenIEnteredCertificateAndYear()
//{
//    ProfileObj.AddCertifications();
//}

//[Then(@"profile page should display added certification details")]
//public void ThenProfilePageShouldDisplayAddedCertificationDetails()
//{
//    ProfileObj.GetCertificationDetails();
//}



//        [When(@"I add my education details '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)'")]
//        public void WhenIAddMyEducationDetails(string Country, string institute, string title, string degree, string year)
//        {
//            ProfileObj.AddEducation(Country, institute, title, degree, year);
//        }

//        [Then(@"the profile page should show the added Education details successfully\.")]
//        public void ThenTheProfilePageShouldShowTheAddedEducationDetailsSuccessfully(string Country, string institute, string title, string degree, string year)
//        {
//            ProfileObj.GetEducation(Country, institute, title, degree, year);
//        }
//    }
//}









