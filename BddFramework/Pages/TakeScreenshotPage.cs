using Bdd_Task.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;

namespace BddFramework.Pages
{
    class TakeScreenshotPage
    {
        public TakeScreenshotPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }

        #region Elements
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Our stores')]")]
        IWebElement OurStoresLink { get; set; }

        [FindsBy(How = How.ClassName, Using = "dismissButton")]
        IWebElement GoogleDismissButton { get; set; }

        [FindsBy(How = How.XPath, Using = " //div[@class='gm-style']")]
        IWebElement SourceElement { get; set; }
        //div[@class='gm-style']

        #endregion

        #region Actions
        public void OurStoreLink()
        {
            //click on our stores link 
            OurStoresLink.Click();

            // Click on OK button of Google message 
            GoogleDismissButton.Click();
        }

        public void Screenshot()
        {
            // Taking screenshot of Map page
            Screenshot screen = Hooks.driver.TakeScreenshot();
            screen.SaveAsFile(@"C:\Users\Nadeem\Sample.Png", ScreenshotImageFormat.Jpeg);
        }
        #endregion

    }
}
