using EP.Base;
using EP.Page;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EP
{
    [Binding]
    [Scope(Tag = "Regression"), Scope(Tag = "HomeTabs")]
    public class HomeTabsTestSteps : SetUp
    {
        public IWebDriver Browser;
        public HomeTabsPage page;

        [Given(@"I navigate to EdgePetrol")]
        public void GivenINavigateToEdgePetrol()
        {
            Browser = Driver;
            page = new HomeTabsPage(Browser);
            Driver.Navigate().GoToUrl("https://www.edgepetrol.com/");
        }

        [When(@"I click (.*)")]
        public void WhenIClickTabs(string link)
        {
            page.ClickHomeTabs(link);
        }

        [Then(@"I see corresponding (.*) pages")]
        public void ThenISeeCorrespondingTabsPages(string link)
        {
            page.CheckHomeTabs(link);
        }
    }
}