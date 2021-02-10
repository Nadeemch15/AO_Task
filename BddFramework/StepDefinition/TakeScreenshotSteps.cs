using Bdd_Task.Utilities;
using BddFramework.Pages;
using System;
using TechTalk.SpecFlow;

namespace BddFramework.StepDefinition
{
    [Binding]
    public class TakeScreenshotSteps
    {
        TakeScreenshotPage TakeScreenshot;
        public TakeScreenshotSteps()
        {
          TakeScreenshot = new TakeScreenshotPage();
        }
        [Given(@"I am on the Automation website")]
        public void GivenIAmOnTheAutomationWebsite()
        {
            Hooks.driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [When(@"I click the Our store link and take screenshot")]
        public void WhenIClickTheOurStoreLinkAndTakeScreenshot()
        {
            TakeScreenshot.OurStoreLink();
        }

        [Then(@"I am able to take the screenshot")]
        public void ThenIAmAbleToTakeTheScreenshot()
        {
            TakeScreenshot.Screenshot();
        }
    }
}
