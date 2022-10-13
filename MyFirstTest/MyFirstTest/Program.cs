
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V104.Target;
using System.Xml.Linq;

//open chrome browser
IWebDriver driver = new ChromeDriver();

//navigate to URL
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
driver.Manage().Window.Maximize();

//identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("Hari");

//identify password textbox and enter valid password
IWebElement userPassword = driver.FindElement(By.Id("Password"));
userPassword.SendKeys("123123");

//click login button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1])"));
loginButton.Click();

//check if user login successfully

IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\'logoutForm\']/ul/li/a"));

if (helloHari.Text == "Hello hari")
{
    Console.WriteLine("login successfully text passed");
}
else
{
    Console.WriteLine("Login unSuccessfully test failed");
}

//Create Time record


//Navigate Time and material
IWebElement administrationdropdown = driver.FindElement(By.XPath("/html / body / div[3] / div / div / ul / li[5] / a"));
administrationdropdown.Click();

IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmoption.Click();

//Click on create new button
IWebElement createnew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createnew.Click();

//select time from dropdown
IWebElement Typecode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
Typecode.Click();
Thread.Sleep(500);

IWebElement SelectTime = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
SelectTime.Click();

//Enter code in code textbox
IWebElement enterCode = driver.FindElement(By.Id("Code"));
enterCode.SendKeys("Sepetember");


//Enter Description in textbox
IWebElement DescriptionBox = driver.FindElement(By.Id("Description"));
DescriptionBox.SendKeys("sun");

//Enter price in textbox

IWebElement inputBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
inputBox.Click();

IWebElement PriceUnitBox = driver.FindElement(By.Id("Price"));
PriceUnitBox.SendKeys("170");


//click on save button
IWebElement SaveButton = driver.FindElement(By.Id("SaveButton"));
SaveButton.Click();
Thread.Sleep(2000);

//check if new time record created successfully
IWebElement goTOLastPage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goTOLastPage.Click();

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[Last()]/td[1]"));

if (newCode.Text == "September")
{
    Console.WriteLine("new record created successfully");
}
else
{
    Console.WriteLine("new record is not created");
        }

        

 

    

