
using Bdd_Task.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Bdd_Task.PageObject
{
    class SelectSliderPage
    {
        public SelectSliderPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//div[@id='left_column']//a[2]")]
        IWebElement Slider { get; set;}

        public void SelectSlider()
        
        {
            // Scroll down
            IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks.driver;
            js.ExecuteScript("window.scrollBy(0, 1000)");

            //slider change the price                   
            Actions move = new Actions(Hooks.driver);
            move.DragAndDropToOffset(Slider, -105, 0).Perform();
            /*price has been changed - but there is defect in website it's loading 
            * the page indefinitely */
    } }
}
