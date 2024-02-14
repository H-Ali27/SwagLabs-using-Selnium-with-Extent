using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Swaglabs_Framework
{
    internal class OverviewPage : baseclass
    {
        By submitBtn = By.XPath("//*[@id=\"checkout_summary_container\"]/div/div[2]/div[8]/a[2]");
        public void Overview()
        {
            extentreport.ChildLog("Overview Page");
            action("click", submitBtn, "FinishButton", "finishBtn", "FinishBtn.png", path, "scrolldown", 250);
        }
    }
}
