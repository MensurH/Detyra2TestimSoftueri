using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detyra2TestimSoftueri
{
    public class TS7_TC1
    {
        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://www.hltv.org/matches");
        }
        [Test]
        public void TopTier()
        {
            Driver.driver.FindElement(By.CssSelector("body > div.bgPadding > div > div.colCon > div.contentCol > div.newMatches > div.standardPageGrid > div > div.liveMatchesSection > div.mach-filter-wrapper > div > div.match-filter-box > div > a:nth-child(2) > div")).Click();


            IWebElement resultsContainer = Driver.driver.FindElement(By.ClassName("upcomingMatchesContainer"));
            IReadOnlyCollection<IWebElement> matchRatings = resultsContainer.FindElements(By.ClassName("matchRatings"));
            foreach (IWebElement item in matchRatings)
            {
                Assert.IsFalse(item.Text.Contains("faded"));
            }

        }
        [Test]
        public void LAN()
        {
            Driver.driver.FindElement(By.Name("")).Click();


            IWebElement resultsContainer = Driver.driver.FindElement(By.ClassName("filter-button"));
            Assert.IsTrue(resultsContainer.Text.Contains("selected"));
        }

    }
}
