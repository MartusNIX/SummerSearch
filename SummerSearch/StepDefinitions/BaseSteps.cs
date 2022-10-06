using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SummerSearch.StepDefinitions
{
    public class BaseSteps
    {
        protected IWebDriver webDriver;

        public BaseSteps(IWebDriver driver)
        {
            webDriver = driver;
        }
    }
}
