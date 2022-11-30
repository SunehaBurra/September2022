using Mars_Project.Utilities;
using OpenQA.Selenium.DevTools.V105.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Mars_Project.Hooks
{
    [Binding]
    public sealed class Driver : CommonDriver
    { 

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();

        }

        [AfterScenario]
        public void TearDown()
        {
            CloseTestRun();
        }
    }
}             