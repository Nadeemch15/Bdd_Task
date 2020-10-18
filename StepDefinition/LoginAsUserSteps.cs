using Bdd_Task.PageObject;
using Bdd_Task.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Bdd_Task.StepDefinition
{
    [Binding]
    public class LoginAsUserSteps
    {
        LoginUserPage LoginPage;
        public LoginAsUserSteps()
        {
            LoginPage = new LoginUserPage();
        }
        [Given(@"I am on login page")]
        public void GivenIAmOnLoginPage()
        {
            Hooks.driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");

        }
        
        // used parameterise method

        [Given(@"I entere the login details (.*), (.*)")]
        public void GivenIEntereTheLoginDetails(string Email, string Password)
        {
            LoginPage.EnterCredentials(Email, Password);
        }


        //[Given(@"I entere the login details")]
        //public void GivenIEntereTheLoginDetails()
        //{
        //    LoginPage.EnterCredentials();
        //}

        [When(@"I click the SignIn Button")]
        public void WhenIClickTheSignInButton()
        {
            LoginPage.SignIn();
        }

        [Then(@"I logged in successfully")]
        public void ThenILoggedInSuccessfully()
        {
            LoginPage.VerifyLogin();
        }
    }
}
