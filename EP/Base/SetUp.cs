using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace EP.Base
{
    public class SetUp
    {
        public IWebDriver Driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            var browser = new ChromeDriver();
            Driver = browser;
            Maximise();
        }

        [AfterScenario]
        public void AfterScenario()
        {
           
            Driver.Close();
            Driver.Quit();
        }

        public void Maximise()
        {
            Driver.Manage().Window.Maximize();
        }
    }
}

