using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Swaglabs_Framework
{
    internal class InformationPage : baseclass
    {
        By firstname = By.Id("first-name");
        By lastname = By.Id("last-name");
        By postcode = By.Id("postal-code");
        By submitBtn = By.XPath("//*[@id=\"checkout_info_container\"]/div/form/div[2]/input");
        
        public void InformationForm(string FName,string LastName, string P_code) 
        {
            extentreport.ChildLog("Check Out Information");
            action("write",firstname,FName,"firstName","firstName.png",path,"scrolldown", 0);
            action("write", lastname, LastName, "lasstName", "lastName.png", path, "scrolldown", 0);
            action("write", postcode, P_code, "postcode", "postalcode.png", path, "scrolldown", 0);
            action("click", submitBtn, "formSubmit", "formSubmit", "InformationSubmitBtn.png", path, "scrolldown", 0);
        }
    }
}
