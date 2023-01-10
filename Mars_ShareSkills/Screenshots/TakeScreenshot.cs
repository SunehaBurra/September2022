using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_ShareSkills.Screenshots
{
    public class TakeScreenshot
    {
        public static void ScreenShotMethod(IWebDriver driver)
        {
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(@"C:\Users\RAM REDDY\First Project2022\September2022\Mars_ShareSkills\Screenshots" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".jpeg", ScreenshotImageFormat.Jpeg);
        }
    }
}
