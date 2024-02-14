using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Swaglabs_Framework
{
    internal class InventoryPage : baseclass
    {
        By product1 = By.XPath("//*[@id=\"inventory_container\"]/div/div[1]/div[3]/button");
        By product2 = By.XPath("//*[@id=\"inventory_container\"]/div/div[2]/div[3]/button");
        By sorting = By.ClassName("product_sort_container");
        By product3 = By.XPath("//*[@id=\"inventory_container\"]/div/div[3]/div[3]/button");
        By product4 = By.XPath("//*[@id=\"inventory_container\"]/div/div[1]/div[3]/button");
        By product5 = By.XPath("//*[@id=\"inventory_container\"]/div/div[2]/div[3]/button");
        By cartIcon = By.CssSelector("#shopping_cart_container");
        public void Inventory()
        {
            extentreport.ChildLog("Inventory Page");
            action("click", product1, "product1", "laptopBag", "product1.png", path, "scrolldown",0);
            action("click", product2, "product2", "BikeLite", "product2.png", path, "scrolldown", 20);
            action("click", product3, "product3", "Tshirt", "product3.png", path, "scrolldown", 40);
            
            action("select", sorting, "Name (Z to A)", "sorting", "sortingSelect.png", path, "scrollup", 0);
            Thread.Sleep(2000);

            action("click", product4, "product4", "T-Shirt", "product4.png", path,"scrollup",0);
            action("click", product5, "product5", "labsOnesie", "product5.png", path, "scrolldown", 60);
            
            action("click", cartIcon, "cart", "cartIcon", "cartIcon.png", path, "scrollup", 0);
            //Thread.Sleep(2000);
        }
    }
}
