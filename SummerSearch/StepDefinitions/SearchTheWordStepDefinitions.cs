using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SummerSearch.StepDefinitions
{
    [Binding]
    public class SearchTheWordStepDefinitions : BaseSteps
    {
        public SearchTheWordStepDefinitions(IWebDriver driver) : base(driver)
        {
        }

        [Given(@"I launch the page")]
        public void GivenILaunchThePage()
        {
            webDriver.Navigate().GoToUrl("http://automationpractice.com/");
        }

/*        [Given(@"I insert word in searchfield Summer")]
        public void GivenIInsertWordInSearchfieldSummer()
        {
            var inputText = webDriver.FindElement(By.Id("search_query_top"));
            inputText.SendKeys("Summer");
        }

        [When(@"I click on magnifier")]
        public void WhenIClickOnMagnifier()
        {
            var pressSearchBtn = webDriver.FindElement(By.Name("submit_search"));
        }

        [Then(@"I see the same words SUMMER")]
        public void ThenISeeTheSameWordsSUMMER()
        {
            throw new PendingStepException();
        }*/
    }
}
