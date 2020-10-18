using Bdd_Task.PageObject;
using Bdd_Task.Utilities;
using OpenQA.Selenium.Support.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace Bdd_Task.StepDefinition
{
    [Binding]
    public class AddItemtoCartSteps
    {
        DisplaySummerDressesPage SummerDress;
        AddItemtoCartPage AddtoCart;

        public AddItemtoCartSteps()
        {
            SummerDress = new DisplaySummerDressesPage();
            AddtoCart = new AddItemtoCartPage();
        }
        [Given(@"I am on the Website")]
        public void GivenIAmOnTheWebsite()
        {
            Hooks.driver.Navigate().GoToUrl("http://automationpractice.com/index.php");

        }

        [Given(@"I select the summer dress")]
        public void GivenISelectTheSummerDress()
        {
            SummerDress.SelectSummerDress();
        }

        [When(@"I click proceed to the Checkout")]
        public void WhenIClickProceedToTheCheckout()
        {
            AddtoCart.ProceedCheckout();
        }

        [Then(@"Item added to the cart")]
        public void ThenItemAddedToTheCart()
        {
            AddtoCart.VerifySelectedItem();
        }
    }
}
