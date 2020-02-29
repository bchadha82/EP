using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using EP.Base;
using FluentAssertions;

namespace EP.Page
{
    public class ForgotPasswordPage : BasePage
    {
        public ForgotPasswordPage(IWebDriver driver) : base(driver)
        {

        }

        [FindsBy(How = How.LinkText, Using = "Login")]
        public IWebElement LoginIcon;

        [FindsBy(How = How.LinkText, Using = "Forgot your password?")]
        public IWebElement ForgotPasswordIcon;

        public void ClickLogin()
        {
            
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            LoginIcon.Click();
        }

        public void ClickForgotPassword()
        {
            
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            ForgotPasswordIcon.Click();
        }

        public void CheckForgotPassword()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Driver.PageSource.Contains("btn btn-primary btn-lg btn-block");
        }
    }
}
