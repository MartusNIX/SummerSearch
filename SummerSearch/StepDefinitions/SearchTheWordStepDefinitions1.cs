using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SummerSearch.PageObjects;
using SummerSearch.StepDefinitions;
using TechTalk.SpecFlow;

namespace SummerSearch.StepDefinitions
{
    [Binding]
    public class SearchTheWordStepDefinitions : BaseSteps
    {
        MainPage mainPage;
        SearchResultPage resultPage;

        public SearchTheWordStepDefinitions(IWebDriver driver) : base(driver)
        {
            mainPage = new MainPage(webDriver);
            resultPage = new SearchResultPage(webDriver);
        }

        [Given(@"I launch the page")]
        public void GivenILaunchThePage()
        {
            webDriver.Navigate().GoToUrl("http://automationpractice.com/");
        }

        [Given(@"I insert word in searchfield Summer")]
        public void GivenIInsertWordInSearchfieldSummer()
        {
            mainPage.InsertWordInSearchfield("Summer");
        }

        [When(@"I click on magnifier")]
        public void WhenIClickOnMagnifier()
        {
            mainPage.ClickSearchBtn();
        }

        [Then(@"I see the same words SUMMER")]
        public void ThenISeeTheSameWordsSUMMER()
        {
            var insertedWord = resultPage.GetInsertedWord();
            var displayedWordInHeader = resultPage.GetDisplayedWord();
            Assert.AreEqual(insertedWord, displayedWordInHeader);
        }
    }
}
