using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Swaglabs_Framework
{

    [TestClass]
    public class ExecutionClass : baseclass
    {
        [TestInitialize]
        public void Init ()
        {
            SeleniumInit("chrome");
            extentreport.Report();
        }
        [TestCleanup]
        public void TestCleanUp() 
        {
            DriveClose();
            extentreport.flush();
        }

        Loginpage loginpage = new Loginpage();
       
        [TestMethod]
        public void Swaglabs_Framework()
        {

            //sdriver.Navigate().GoToUrl("https://www.saucedemo.com/v1/index.html");
            loginpage.Valid_login("https://www.saucedemo.com/v1/index.html", "standard_user", "secret_sauce", "jack","jones","12344332");
            //loginpage.Invalid_login("https://www.saucedemo.com/v1/index.html", "stdard_user", "secret_sauce");
          
        }
        [TestMethod]
        public void Invalid_Login() 
        {
            loginpage.Valid_login("https://www.saucedemo.com/v1/index.html", "standard", "secret_sauce", "jack", "jones", "12344332");
        }
    }
}
