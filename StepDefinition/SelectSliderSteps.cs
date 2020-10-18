using Bdd_Task.PageObject;
using Bdd_Task.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Bdd_Task.StepDefinition
{
    [Binding]
    public class SelectSliderToSetThePriceSteps
    {
        DisplaySummerDressesPage SummerDress;
        SelectSliderPage SSlider;
        public SelectSliderToSetThePriceSteps()
        {
            SummerDress = new DisplaySummerDressesPage();
            SSlider = new SelectSliderPage();
        }
        [Given(@"I am on Slider Page")]
        public void GivenIAmOnSliderPage()
        {
            Hooks.driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
        }

        [When(@"I set the price rang on slider")]
        public void WhenISetThePriceRangOnSlider()
        {
            SummerDress.SelectSummerDress();
        }

        [Then(@"the price has set on slider")]
        public void ThenThePriceHasSetOnSlider()
        {
            SSlider.SelectSlider();
        }
    }
}
