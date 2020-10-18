using Bdd_Task.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Bdd_Task.PageObject
{
    class TakeScreenshotPage
    {
        public TakeScreenshotPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Our stores')]")]
        IWebElement OurStoresLink { get; set; }

        [FindsBy(How = How.ClassName, Using = "dismissButton")]
        IWebElement GoogleDismissButton { get; set; }

        [FindsBy(How = How.XPath, Using = " //div[@class='gm-style']")]
        IWebElement SourceElement { get; set; }
        //div[@class='gm-style']

        public void OurStoreLink()
        {
            //click on our stores link 
            OurStoresLink.Click();

            Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            // Click on OK button of Google message 
            GoogleDismissButton.Click();
        }

        public void Screenshot()
        {
            // Taking screenshot of Map page
            Screenshot screen = Hooks.driver.TakeScreenshot();
            screen.SaveAsFile("Screen4.jpeg", ScreenshotImageFormat.Jpeg);

            // location of screenshot 
            //   C:\Users\Nadeem\AppData\Local\Temp\Screen4.jpeg 
        }

    }
}

