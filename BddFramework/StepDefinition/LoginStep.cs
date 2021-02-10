using Bdd_Task.PageObject;
using Bdd_Task.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BddFramework
{
    [Binding]
    public class LoginSteps
    {
        
        LoginPage login;
        CommonFunctions common;
        public LoginSteps()
        {
          login = new LoginPage();
          common = new CommonFunctions();
        }

        [Given(@"I am on login page")]
        public void GivenIAmOnLoginPage()
        {
            Hooks.driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            Hooks.driver.Manage().Window.Maximize();
        }

        [When(@"I entere the login details (.*), (.*) and I click the SignIn Button")]
        public void WhenIEntereTheLoginDetailsAndIClickTheSignInButton(string Email, string Password)
        {
            //login
            login.EnterCredentials(Email, Password);
            
        }

        [Then(@"I logged in successfully")]
        public void ThenILoggedInSuccessfully()
        {
            common.CheckPageTitle("My account - My Store");
        }
    }
}
