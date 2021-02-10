using Bdd_Task.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace BddFramework.Pages
{
    class DisplayDressPage
    {
        public DisplayDressPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        #region Elements
        [FindsBy(How = How.ClassName, Using = "sf-with-ul")]
        public IWebElement WomenTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@class='sfHover']//a[contains(text(),'Summer Dresses')]")]
        public IWebElement ClickSummerdress { get; set; }

        [FindsBy(How = How.ClassName, Using = "cat-name")]
        public IWebElement SummerDressTitle { get; set; }
        #endregion

        #region Actions
        public void SelectSummerDress()
        {
            // Mouse-hover button 'WOMEN'
            Actions action = new Actions(Hooks.driver);
            action.MoveToElement(WomenTab).Perform();
            ClickSummerdress.Click();
        }
        public void VerifySummerDress()
        {
            // only Summer dresses displayed 
            Assert.AreEqual(SummerDressTitle.Text, "SUMMER DRESSES ");
            Console.WriteLine(SummerDressTitle.Text + " are displayed");
        }
        #endregion

    }
}
