using Bdd_Task.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace Bdd_Task.PageObject
{
    class LoginUserPage
    {
        public LoginUserPage()
        {
            PageFactory.InitElements(Hooks.driver, this);
        }
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement Email { get; set; }
        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Nadeem')]")]
        public IWebElement VerifyUser { get; set; }
        public void EnterCredentials(string email, string password)
        {
            Email.SendKeys(email);
            Password.SendKeys(password);
        }
        public void SignIn()
        {
            SignInButton.Click();

            // Scroll down - java script code added 
            IJavaScriptExecutor js = (IJavaScriptExecutor)Hooks.driver;
            js.ExecuteScript("window.scrollBy(0, 1000)");
        }

        public void VerifyLogin()
        {
            Assert.AreEqual("Nadeem CDS", VerifyUser.Text);
            Console.WriteLine(VerifyUser.Text + " Displayed");
        }
    }
}

