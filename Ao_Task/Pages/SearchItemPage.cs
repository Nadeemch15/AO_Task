using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ao_Task.Pages
{
    class SearchItemPage
    {
        public SearchItemPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }


        #region Elements
        [FindsBy(How = How.Id, Using = "siteSearch-input")]
        public IWebElement SearchBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = ".siteSearch__search-button > .ico")]
        public IWebElement SearchButton { get; set; }

        [FindsBy(How = How.LinkText, Using = "Hotpoint")]
        public IWebElement Hotpoint { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#style-1")]
        public IWebElement Slider { get; set; }


        [FindsBy(How = How.XPath, Using = "//body/div[@id='holder']/div[@id='container']/main[@id='app']/div[2]/div[1]/div[1]/aside[1]/div[2]/div[4]/div[2]/fieldset[1]/div[1]/a[1]/label[1]/span[1]")]
        public IWebElement LoadSize { get; set; }


        [FindsBy(How = How.XPath, Using = "//h1[contains(text(),'Washing Machines with 10 Kg, 10.5 Kg, 11 Kg, 12 Kg')]")]
        public IWebElement Validate { get; set; }

        #endregion

        #region Actions
        public void SearchItem()
        {
            // search for washing machine
            SearchBox.SendKeys("Washing Machines");
            SearchButton.Click();
        }

        public void HotpointMachine()
        {
            //Select Hotpoint 
            Hotpoint.Click();
        }

        public void WashLoadLarge()
        {
            // Navigate to left filter
            Actions move = new Actions(Hooks.driver);
            move.DragAndDropToOffset(Slider, 0, 150).Perform();

            // select wash load
            LoadSize.Click();

        }
        public void VerifySilverMachine()
        {
            // Verify the result
            Assert.AreEqual(Validate.Text, "Washing Machines with 10 Kg, 10.5 Kg, 11 Kg, 12 Kg, 15 Kg wash load");
            // display the required result
            Console.WriteLine(Validate.Text + " are displayed");
        }
    }

    #endregion
}

