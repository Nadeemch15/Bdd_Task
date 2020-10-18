using Bdd_Task.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Bdd_Task.PageObject
{
    class DisplaySummerDressesPage
    {
        public DisplaySummerDressesPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[@class='sf-with-ul'][contains(text(),'Women')]")]
        public IWebElement WomenTab { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[@class='sfHover']//a[contains(text(),'Summer Dresses')]")]
        public IWebElement ClickSummerdress { get; set; }

        [FindsBy(How = How.ClassName, Using = "cat-name")]
        public IWebElement SummerDressTitle { get; set; }

        public void SelectSummerDress()
        {
            // Mouse-hover button 'WOMEN'
            Actions action = new Actions(Hooks.driver);
            action.MoveToElement(WomenTab).Perform();
            ClickSummerdress.Click();
        }

        public void VerifySummerDress()
        {
            // only Summer dresses displayed 
            Assert.AreEqual(SummerDressTitle.Text, "SUMMER DRESSES ");
            Console.WriteLine(SummerDressTitle.Text + " are displayed");
        }
    }
}

