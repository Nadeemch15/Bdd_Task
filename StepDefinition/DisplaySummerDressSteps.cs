using Bdd_Task.PageObject;
using Bdd_Task.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Bdd_Task.StepDefinition
{
    [Binding]
    public class DisplaySummerDressSteps
    {
        DisplaySummerDressesPage SummerDress;
        public DisplaySummerDressSteps()
        {
            SummerDress = new DisplaySummerDressesPage();
        }
        [Given(@"I am on Search Page")]
        public void GivenIAmOnSearchPage()
        {
            Hooks.driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            //Hooks.driver.Manage().Window.FullScreen();
        }

        [When(@"I mouse hover on WOMEN Tab and click Summer dresses")]
        public void WhenIMouseHoverOnWOMENTabAndClickSummerDresses()
        {
            SummerDress.SelectSummerDress();
        }

        [Then(@"Summer dresses are displayed")]
        public void ThenSummerDressesAreDisplayed()
        {
            SummerDress.VerifySummerDress();
        }
    }
}
