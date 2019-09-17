using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class NUnitTest
    {
        string googleUrl = "http://google.com";
        string searchElementName = "q";
        string searchQuery = "brunoklein github";

        // create the driver reference
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Initialize()
        {
            // navite to google page
            webDriver.Navigate().GoToUrl(googleUrl);
        }

        [Test]
        public void ExecuteTest()
        {
            // find the element
            IWebElement searchElement = webDriver.FindElement(By.Name(searchElementName));
            // perform ops
            searchElement.SendKeys(searchQuery);
        }

        [TearDown]
        public void CleanUp()
        {
            webDriver.Close();
        }
    }
}

