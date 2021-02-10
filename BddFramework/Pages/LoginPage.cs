using Bdd_Task.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Bdd_Task.PageObject
{
    public class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        #region Elements
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement SignInButton { get; set; }

        #endregion

        #region Actions
        public void EnterCredentials(string email, string password)
        {
            Email.SendKeys(email);
            Password.SendKeys(password);
            SignInButton.Click();
        }

        #endregion

    }
}

