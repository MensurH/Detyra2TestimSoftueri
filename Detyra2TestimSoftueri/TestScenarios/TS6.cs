using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detyra2TestimSoftueri.TestScenarios
{
   
    public class TS6
    {
        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://www.hltv.org/matches");
        }
        [Test]
        public void Event()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[1]/nav/a[6]")).Click();


            IWebElement resultsContainer = Driver.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/div[1]/div[2]/div[1]/div/div/div[1]/form/select"));
            IReadOnlyCollection<IWebElement> matchRatings = resultsContainer.FindElements(By.ClassName("event__match"));
            foreach (IWebElement item in matchRatings)
            {
                Assert.IsFalse(item.Text.Contains("match--live"));
            }

        }
    }
}
