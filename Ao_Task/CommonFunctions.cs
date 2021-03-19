using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ao_Task
{
    public class CommonFunctions
    {
        public void Scrolldown()
        {
            // Scroll down  
            IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks.driver;
            js.ExecuteScript("window.scrollBy(0, 3000)");
        }

        public void Scrolldown_1500()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks.driver;
            js.ExecuteScript("window.scrollBy(0, 1500)");

        }

        public void Wait()
        {
            //implicit wait 
            Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

    }
}

