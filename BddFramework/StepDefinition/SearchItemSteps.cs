using Bdd_Task.Utilities;
using BddFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using TechTalk.SpecFlow;

namespace BddFramework.StepDefinition
{
    [Binding]
    public class SearchItemSteps
    {
        CommonFunctions Common;
        SearchItemPage Search;
        public SearchItemSteps()
        {
            Search = new SearchItemPage();
            Common = new CommonFunctions();
        }
        [Given(@"I am on AO website")]
        public void GivenIAmOnAOWebsite()
        {
            Hooks.driver.Navigate().GoToUrl("https://ao.com/");
        }
        
        [Given(@"I search for washing machines and click search button")]
        public void GivenISearchForWashingMachinesAndClickSearchButton()
        {
            Search.SearchItem();
        }

        [Given(@"I Select Hotpoint washing machine")]
        public void GivenISelectHotpointWashingMachine()
        {
            Common.Scrolldown();
            Search.HotpointMachine();
        }


        [When(@"I Select wash load large")]
        public void WhenISelectWashLoadLarge()
        {
            Common.Wait();
            Common.Scrolldown_1500();
            Search.WashLoadLarge();
        }


        [Then(@"the list of Hotpoint Large washing machine displayed")]
        public void ThenTheListOfHotpointLargeWashingMachineDisplayed()
        {
            Search.VerifySilverMachine();
        }
    }
}
