using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstTest.Pages;


    IWebDriver driver = new ChromeDriver();

//login page object initializing
LoginPage Obj1 = new LoginPage();
Obj1.LoginSteps(driver);

//Home page object initializing
HomePage Obj2 = new HomePage();
Obj2.GoToHomepage(driver);
//create object
TMpage Obj3 = new TMpage();
Obj3.CreateTM(driver);




    
