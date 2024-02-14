using MongoDB.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Swaglabs_Framework
{
    public class baseclass 
    {
        public static IWebDriver driver;
        public static string path = "E:\\Seleium\\Swaglabs_Framework\\bin\\Screenshot\\";
        public static void SeleniumInit(string browser)
        {
            BOptions(browser);
            driver.Manage().Window.Maximize();
        }
        public static void DriveClose() 
        {
            driver.Close();
            driver.Quit();
        }
        public static void screenshot(string filename, string path, string fileformat) 
        {
            fileformat.ToUpper();
            Screenshot image_user = ((ITakesScreenshot)baseclass.driver).GetScreenshot();
            if(fileformat == "PNG")
            {
                image_user.SaveAsFile(path + filename,ScreenshotImageFormat.Png);
            }
            else if(fileformat == "JPEG")
            {
                image_user.SaveAsFile(path + filename, ScreenshotImageFormat.Jpeg);
            }

        }
        public static void BOptions(string browser) 
        {
            if(browser == "chrome") 
            {
                driver = new ChromeDriver();
            }
            else if(browser == "firefox") 
            {
                driver = new FirefoxDriver();
            }
            else if (browser == "edge")
            {
                driver = new EdgeDriver();
            }
        }

        public static void write(By by, string text,string detail1,string filename1, string path, string childnode = "")
        {
            try 
            {
                driver.FindElement(by).SendKeys(text);
                extentreport.ChildLog(childnode);
                extentreport.LogReport(detail1,filename1,path);
            }
            catch 
            {
                extentreport.LogReportFailed(detail1,filename1,path);
            }
        }
        public static void action(string operation, By by, string text,string detail1,string filename1, string path, string direct, int value)
        {
            if (operation == "write")
            {
                driver.FindElement(by).SendKeys(text);
                extentreport.LogReport(detail1, filename1, path);
                JS_Executor(direct,value);
            }   
            else if (operation == "click")
            {
                try
                {
                    JS_Executor(direct, value);
                    extentreport.LogReport(detail1, filename1, path);
                    driver.FindElement(by).Click();
                    Thread.Sleep(2000);
                }
                catch(Exception ex)
                {
                    extentreport.LogReportFailed(detail1,filename1,path);   
                    throw ex;
                }
            }
            else if (operation == "text")
            {
                try
                {
                    JS_Executor(direct, value);
                    string asserttext = driver.FindElement(by).Text;
                    extentreport.LogReport(detail1, filename1, path);
                }
                catch
                {
                    extentreport.LogReportFailed(detail1, filename1, path);
                    throw;
                }
            }
            else if(operation == "select")
            {
                var dropdown = driver.FindElement(by);
                var selectdropdown = new SelectElement(dropdown);
                selectdropdown.SelectByText(text);
                extentreport.LogReport(detail1,filename1, path);
            }
        }

        public static void JS_Executor(string direct, int value)
        {   
            IJavaScriptExecutor js = ((IJavaScriptExecutor)driver);
            direct.ToUpper();
            if(direct == "SCROLLDOWN")
            {
                js.ExecuteScript("window.scrollBy(0," + value + ")");
            }
            if(direct == "SCROLLUP")
            {
                js.ExecuteScript("window.scrollBy(0", +value + ")");
            }
        }
    }
}
