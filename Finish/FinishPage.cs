using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Swaglabs_Framework
{
    internal class FinishPage : baseclass
    {
        By finishtext = By.XPath("/html/body/div/div[2]/div[3]/h2");
        public void FinishFlow()
        {
            extentreport.ChildLog("Thank You Page");
            Thread.Sleep(3000);
            action("text", finishtext, "GreetingTex", "greetings", "thankyou.png", path, "scrolldown", 0);
        }
    }
}
