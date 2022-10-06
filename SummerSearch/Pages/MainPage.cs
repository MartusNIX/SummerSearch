using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SummerSearch.Pages
{
    internal class MainPage
    {
        public IWebDriver WebDriver { get; }
        public MainPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement searchField => WebDriver.FindElement(By.Id("search_query_top"));
        public IWebElement searchBtn => WebDriver.FindElement(By.Name("submit_search"));


        public void InsertWordInSearchfield(string text) => searchField.SendKeys(text);
        public void ClickSearchBtn() => searchBtn.Click();
    }
}
