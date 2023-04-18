

using OpenQA.Selenium.Chrome;

namespace nunittest;

public class Tests
{
    OpenQA.Selenium.IWebDriver driver;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver("../driver/chromdriver");
    }

    [Test]
    public void Test1()
    {
        driver.Navigate().GoToUrl("https://www.jobstreet.com/");
        driver.FindElement(OpenQA.Selenium.By.XPath("//span[contains(text(),'Indonesia')]")).Click();
        driver.FindElement(OpenQA.Selenium.By.Id("locationAutoSuggest")).SendKeys("Balikpapan");
        driver.FindElement(OpenQA.Selenium.By.XPath("//button[@class='_23enrv0']")).Click();
        Thread.Sleep(5000);
    }

    [TearDown]
    public void dispatch(){
        driver.Close();
    }
}
