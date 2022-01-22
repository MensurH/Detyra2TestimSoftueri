using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detyra2TestimSoftueri.TestScenarios
{
   public class TS1_Filma24
    {
        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://www.filma24.bz/");
        }

        [Test]
        public void Live()
        {
            Driver.driver.FindElement(By.CssSelector("body > div.main > div.head > div > div.head-menu > div")).Click();

            Driver.driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div/div[3]/div/ul/li[20]/a/span")).Click();

            IWebElement resultsContainer = Driver.driver.FindElement(By.Id("movies-grid"));
            IReadOnlyCollection<IWebElement> matchRatings = resultsContainer.FindElements(By.ClassName("movie-thumb"));
            foreach (IWebElement item in matchRatings)
            {
                Assert.IsTrue(item.Text.Contains("Komedi"));
            }

        }
    }
}
