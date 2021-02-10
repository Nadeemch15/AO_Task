using Bdd_Task.Utilities;
using BddFramework.Pages;
using System;
using TechTalk.SpecFlow;

namespace BddFramework
{
    [Binding]
    public class DisplaySummerDressSteps
    {
        DisplayDressPage Dress;
        public DisplaySummerDressSteps()
        {
            Dress = new DisplayDressPage();
        }
        [Given(@"I am on Search Page")]
        public void GivenIAmOnSearchPage()
        {
            Hooks.driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            Hooks.driver.Manage().Window.FullScreen();
        }

        [When(@"I mouse hover on WOMEN Tab and click Summer dresses")]
        public void WhenIMouseHoverOnWOMENTabAndClickSummerDresses()
        {
           Dress.SelectSummerDress();
        }
        
        [Then(@"Summer dresses are displayed")]
        public void ThenSummerDressesAreDisplayed()
        {
            Dress.VerifySummerDress();
        }
    }
}
