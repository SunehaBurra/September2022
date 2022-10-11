
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Xml.Linq;

//open chrome browser
IWebDriver driver = new ChromeDriver();

//navigate to URL
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

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

