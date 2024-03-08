using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumProject1
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            ChromeOptions options=new ChromeOptions();
            options.AcceptInsecureCertificates = true;
            options.AddExcludedArgument("enable-automation");
            options.AddArgument("start-maximized");

            IWebDriver driver = new ChromeDriver(options);
            //driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.amazon.in/");

            //Id
            //driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("T-Shirt");

            //Name
            //driver.FindElement(By.Name("field-keywords")).SendKeys("T-Shirt");

            //LinkText
            //driver.FindElement(By.LinkText("Best Sellers")).Click();

            //PartialLinkText
            //driver.FindElement(By.PartialLinkText("Sellers")).Click();

            //TagName
            //IList<IWebElement> list = driver.FindElements(By.TagName("div"));
            //Console.WriteLine(list.Count);

            //CssSelector
            //driver.FindElement(By.CssSelector("input[type='text']")).SendKeys("T-Shirts");

            // Xpath
            //We have 2 xpaths absolute xpath which starts from root node to the element node
            //and second is relative xpath with syntax as //tagname[@attributename='value']
            driver.FindElement(By.XPath("//input[@type='text']")).SendKeys("T-Shirts");
        }
    }
}