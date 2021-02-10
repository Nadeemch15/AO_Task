using Bdd_Task.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace BddFramework.Pages
{
    class AddItemtoCartPage
    {
        public AddItemtoCartPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        #region Elements

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Add to cart')]")]
        IWebElement AddtoCartBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Proceed to checkout')]")]
        IWebElement ProceedtoCheckout { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Printed ")]
        IWebElement VerifyItem { get; set; }
        #endregion

        #region Actions
        public void ProceedCheckout()
        {
            AddtoCartBtn.Click();
            Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            ProceedtoCheckout.Click();           
        }
        public void VerifySelectedItem()
        {
            Assert.AreEqual(VerifyItem.Text, "Printed Summer Dress");
            Console.WriteLine(VerifyItem.Text + " are displayed");
        }
        #endregion
    }
}
