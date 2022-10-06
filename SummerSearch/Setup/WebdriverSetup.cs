using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SummerSearch.Setup
{
    [Binding]
    public class WebdriverSetup
    {
        private IWebDriver _driver;
        private readonly IObjectContainer _container;
        private ScenarioContext _context;

        public WebdriverSetup (/*IWebDriver driver, */IObjectContainer container)
        {
            /*_driver = driver;*/
            _container = container;
            _context = container.Resolve<ScenarioContext>();
        }

        [BeforeScenario]
        public void initialize()
        {
            String browser = ConfigurationManager.AppSettings["Browser"];
            _driver = getDriver("CHROME");
        }

        public IWebDriver getDriver(String requiredDriver)
        {
            switch (requiredDriver)
            {
                case "CHROME":
                    ChromeOptions options = new ChromeOptions();
                    _driver = new ChromeDriver(options);
                    _container.RegisterInstanceAs(_driver);
                    break;
            }
            return _driver;
        }
    }
}
