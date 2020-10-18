using Bdd_Task.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Bdd_Task.PageObject
{
    class AddItemtoCartPage
    {
        public AddItemtoCartPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Add to cart')]")]
        IWebElement AddtoCartBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Proceed to checkout')]")]
        IWebElement ProceedtoCheckout { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Printed ")]
        IWebElement VerifyItem { get; set; }

        public void ProceedCheckout()
        {
            AddtoCartBtn.Click();
            Hooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            ProceedtoCheckout.Click();
        }

        public void VerifySelectedItem()
        {
            Assert.AreEqual(VerifyItem.Text, "Printed Summer Dress");
            Console.WriteLine(VerifyItem.Text + " are displayed");
        }

    }
}
