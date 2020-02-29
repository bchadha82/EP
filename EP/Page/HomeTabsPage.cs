using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using EP.Base;
using FluentAssertions;
using System.Threading;

namespace EP.Page
{
    public class HomeTabsPage : BasePage
    {
        public HomeTabsPage(IWebDriver driver) : base(driver)
        {

        }
        

        [FindsBy(How = How.LinkText, Using = "Product")]
        public IWebElement ProductTab;

        [FindsBy(How = How.LinkText, Using = "Knowledge Centre")]
        public IWebElement KnowledgeCentreTab;

        [FindsBy(How = How.LinkText, Using = "Partners")]
        public IWebElement PartnersTab;

        [FindsBy(How = How.LinkText, Using = "The Team")]
        public IWebElement TheTeamTab;

        [FindsBy(How = How.LinkText, Using = "Careers")]
        public IWebElement CareersTab;

        [FindsBy(How = How.LinkText, Using = "Contact")]
        public IWebElement ContactTab;

        public string ProductLink = "https://www.edgepetrol.com/";
        public string KnowledgeCentreLink = "https://www.edgepetrol.com/blog";
        public string PartnersLink = "https://www.edgepetrol.com/partners";
        public string TheTeamLink = "https://www.edgepetrol.com/the-team";
        public string CareersLink = "https://www.edgepetrol.com/careers";

        public void ClickHomeTabs(string link)
        {
            switch (link)
            {
                case "Product":
                    ProductTab.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Knowledge Centre":
                    KnowledgeCentreTab.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    Thread.Sleep(5000);
                    break;
                case "Partners":
                    PartnersTab.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "The Team":
                    TheTeamTab.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Careers":
                    CareersTab.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Contact":
                    ContactTab.Click();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;

                  
            }
        }

        public void CheckHomeTabs(string link)
        {
            switch (link)
            {
                case "Product":
                    Driver.Url.Contains(ProductLink).Should().BeTrue();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Knowledge Centre":
                    Driver.Url.Contains(KnowledgeCentreLink).Should().BeTrue();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    Thread.Sleep(5000);
                    break;
                case "Partners":
                    Driver.Url.Contains(PartnersLink).Should().BeTrue();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "The Team":
                    Driver.Url.Contains(TheTeamLink).Should().BeTrue();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                    break;
                case "Careers":
                    Driver.Url.Contains(CareersLink).Should().BeTrue();
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;
                case "Contact":
                    Driver.PageSource.Contains("contactlink");
                    Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                    break;

                    



            }
        }


    }
}