using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;

namespace Swaglabs_Framework
{
    internal class Loginpage : baseclass
    {
        extentreport extntReport = new extentreport();
        InventoryPage inventorypage = new InventoryPage();
        CartPage cartpage = new CartPage();
        InformationPage informationpage = new InformationPage(); 
        OverviewPage overviewpage = new OverviewPage(); 
        FinishPage finishpage = new FinishPage();
        
        By username = By.Id("user-name");
        By password = By.Id("password");
        By login = By.Id("login-button");
        By assertText = By.ClassName("product_label");

        public void Valid_login(string url, string user, string pass, string fname,string lname,string postcode) 
        {
            driver.Url = url;
            extentreport.Parent_Log("Valid Login");
            extentreport.ChildLog("Valid Login");
            action("write", username, user, "userName", "username.png", path,"scrolldown",0);
            action("write", password, pass, "password", "password.png", path,"scrolldown", 0);
            action("click", login,"login","loginBtn", "Logins.png", path,"scrolldown", 0);
            action("text", assertText, "Assertion", "assertionPicture", "assertion.png", path, "scrolldown", 0);
            inventorypage.Inventory();
            cartpage.Cart();
            informationpage.InformationForm(fname,lname,postcode);
            overviewpage.Overview();
            finishpage.FinishFlow();
        }
        public void Invalid_login(string url, string user, string pass)
        {
            driver.Url = url;

            extentreport.Parent_Log("InValid Login");
            extentreport.ChildLog("InValid Login");
            action("write", username, user,"username","invalidUsername.png",path,"scrolldown", 0);
            action("write", password, pass,"password","invalidpassword.png",path,"scrolldown", 0);
            action("click", login, "login", "loginBtn", "invalidLoginBtn.png", path, "scrolldown", 0);
        }
    }
}
