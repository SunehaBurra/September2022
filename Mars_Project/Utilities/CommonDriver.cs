using Mars_Project.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Project.Utilities
{
    public class CommonDriver
    {
      
        public static IWebDriver driver { get; set; }

    
    public void Initialize()
    {

        //Defining the browser
        driver = new ChromeDriver();

       
    }


          //Implicit Wait
        public static void UseWait()
     {
    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

      }

             //Close the browser
          public void CloseTestRun()
     {
            driver.Quit();
     }
}
}
