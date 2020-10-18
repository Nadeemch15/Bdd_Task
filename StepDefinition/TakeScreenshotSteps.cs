using Bdd_Task.PageObject;
using Bdd_Task.Utilities;
using System;
using TechTalk.SpecFlow;

namespace Bdd_Task.StepDefinition
{
    [Binding]
    public class TakeScreenshotStep
    {
        TakeScreenshotPage TakeScreenshot;
        public TakeScreenshotStep()
        {
            TakeScreenshot = new TakeScreenshotPage();
        }
        [Given(@"I am on the Automation website")]
        public void GivenIAmOnTheAutomationWebsite()
        {
            Hooks.driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [When(@"I click the Our store link and take screenshot")]
        public void WhenIClickTheOurStoreLinkAndTakeScreenshot()
        {
            TakeScreenshot.OurStoreLink();
        }

        [Then(@"I am able to take the screenshot")]
        public void ThenIAmAbleToTakeTheScreenshot()
        {
            TakeScreenshot.Screenshot();
        }
    }
}
