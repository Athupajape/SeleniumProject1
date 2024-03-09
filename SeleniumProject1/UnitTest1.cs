using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
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

        [Test]
        public void Test2()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElement(By.XPath("//textarea[@class='gLFyf']")).SendKeys("Selenium");
            driver.FindElement(By.XPath("//textarea[@class='gLFyf']")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//a[@href='https://www.selenium.dev/']")).Click();

            //*[@name='q']
        }


        [Test]
        public void Test3()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://www.google.com/");
            WebDriverWait webdriverwait = new WebDriverWait(driver,TimeSpan.FromSeconds(30));
            //Fluent Wait ... Polling Interval in miliseconds
            webdriverwait.PollingInterval = TimeSpan.FromMilliseconds(250);
            webdriverwait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@name='q']")));

            
            driver.FindElement(By.XPath("//*[@name='q']")).SendKeys("Selenium");
            

            
        }
    }
}