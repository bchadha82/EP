using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using EP.Base;
using EP.Page;

namespace EP.Step
{
    [Binding]
    [Scope(Tag = "Regression"), Scope(Tag = "ForgotPassword")]

    public class ForgotPasswordTestSteps : SetUp
    {
        public IWebDriver Browser;
        public ForgotPasswordPage page;

        [Given(@"I Navigate to EdgePetrol")]
        public void GivenINavigateToEdgePetrol()
        {
            Browser = Driver;
            page = new ForgotPasswordPage(Browser);
            Driver.Navigate().GoToUrl("https://www.edgepetrol.com/");
        }

        [Given(@"I Click Login")]
        public void GivenIClickLogin()
        {
            page.ClickLogin();
        }

        [When(@"I Click Forgot Your Password")]
        public void WhenIClickForgotYourPassword()
        {
            page.ClickForgotPassword();
        }

        [Then(@"I see Forgot Your Password Page")]
        public void ThenISeeForgotYourPasswordPage()
        {
            page.CheckForgotPassword();
        }
    }
}
