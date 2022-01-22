using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

namespace Detyra2TestimSoftueri.TestScenarios
{
    public class TS9_Flashscore
    {
        [SetUp]
        public void Setup()
        {
            BrowserActions.InitializeDriver("https://www.flashscore.com/");
        }
        [Test]
        public void Live()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[6]/div[1]/div/div[1]/div[2]/div[4]/div[2]/div/div[1]/div/div[2]")).Click();


            IWebElement resultsContainer = Driver.driver.FindElement(By.XPath("/html/body/div[6]/div[1]/div/div[1]/div[2]/div[4]/div[2]/div/section/div/div"));
            IReadOnlyCollection<IWebElement> matchRatings = resultsContainer.FindElements(By.ClassName("event__match"));
            foreach (IWebElement item in matchRatings)
            {
                Assert.IsFalse(item.Text.Contains("match--live"));
            }

        }

        [Test]
        public void Finished()
        {
            Driver.driver.FindElement(By.XPath("/html/body/div[6]/div[1]/div/div[1]/div[2]/div[4]/div[2]/div/div[1]/div[1]/div[4]")).Click();


            IWebElement resultsContainer = Driver.driver.FindElement(By.ClassName("tabs__tab"));
            Assert.IsTrue(resultsContainer.Text.Contains("selected"));

        }
    }
}
