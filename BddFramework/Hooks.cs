using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Bdd_Task.Utilities
{
    [Binding]
    public sealed class Hooks
    {
        public static IWebDriver driver { get; set; }

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //if(driver != null)
            //{
            //    driver.Close();
            //    driver.Quit();
            //}            
        }
    }
}
