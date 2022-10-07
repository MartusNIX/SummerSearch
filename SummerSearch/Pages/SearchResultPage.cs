using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SummerSearch.Pages
{
    internal class SearchResultPage
    {
        public IWebDriver WebDriver { get; }
        public SearchResultPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement searchField => WebDriver.FindElement(By.Id("search_query_top"));
        public IWebElement headerText => WebDriver.FindElement(By.ClassName("lighter"));

        public string GetInsertedWord() => searchField.GetAttribute("value").ToLower();
        public string GetDisplayedWord() => headerText.Text.TrimStart('\"').TrimEnd('\"').ToLower();
    }
}
