using Bdd_Task.PageObject;
using Bdd_Task.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Bdd_Task.StepDefinition
{
    [Binding]
    public class CreateAccountSteps
    {
         
            CreateAccountPage Account;
            public CreateAccountSteps()
            {
                Account = new CreateAccountPage();
            }
            [Given(@"I am on login page of create account")]
            public void GivenIAmOnLoginPageOfCreateAccount()
            {
                Hooks.driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

            }

            [Given(@"I entered the email address")]
            public void GivenIEnteredTheEmailAddress()
            {
                Account.EnterEmail();
            }

            [Given(@"I entered the personal details")]
            public void GivenIEnteredThePersonalDetails()
            {
                Account.EnterDetial();
            }

            [When(@"I click the Register Button")]
            public void WhenIClickTheRegisterButton()
            {
                Account.Register();
            }

            [Then(@"the user account is created")]
            public void ThenTheUserAccountIsCreated()
            {
                Account.VerifyAccount();
            }
        }
    }
