using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Swaglabs_Framework
{
    internal class CartPage : baseclass
    {
        By removeProduct = By.XPath("//*[@id=\"cart_contents_container\"]/div/div[1]/div[7]/div[2]/div[2]/button");
        By checkoutBtn = By.XPath("//*[@id=\"cart_contents_container\"]/div/div[2]/a[2]");
        public void Cart()
        {
            extentreport.ChildLog("Cart Check Out");
            action("click", removeProduct, "removeprod", "productremove", "productremove.png", path, "scrolldown", 350);
            
            action("click", checkoutBtn, "Checkout", "CheckOutBtn", "chkoutBtn.png", path, "scrolldown",0);
        }
    }
}
