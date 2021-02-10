using Bdd_Task.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BddFramework
{
   public class CommonFunctions
    {
        public void Scrolldown()
        {
            // Scroll down  
            IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks.driver;
            js.ExecuteScript("window.scrollBy(0, 1000)");
        }
        public void CheckPageTitle(string pagetitle)
        {
            Assert.IsTrue(Hooks.driver.Title.Contains(pagetitle));
        }

    }
}
