using OpenQA.Selenium;
using wroautomation.Config;

namespace wroautomation
{
    public class Formulario
	{
		public void Formulariotest(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[1]/div/div/div[2]/span/div")).Click();
            bool waitForm1 = WaitHandler.ElementIsPresent(driver, By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[2]/div/ul/li/span"));
            if (waitForm1)
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[2]/div/ul/li")).Click();
            }
            else
            {
                driver.FindElement(By.Id("item-0")).Click();
            }
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("test1");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("qautomation");
            driver.FindElement(By.Id("userEmail")).Click();
            driver.FindElement(By.Id("userEmail")).SendKeys("test1qautomation@email.com");
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".custom-radio:nth-child(1)")).Click();
            driver.FindElement(By.CssSelector(".custom-radio:nth-child(1) > .custom-control-label")).Click();
            driver.FindElement(By.Id("userNumber")).Click();
            driver.FindElement(By.Id("userNumber")).SendKeys("920308800");
            Thread.Sleep(1000);
            driver.FindElement(By.CssSelector(".custom-checkbox:nth-child(1) > .custom-control-label")).Click();
            driver.FindElement(By.CssSelector(".custom-checkbox:nth-child(2) > .custom-control-label")).Click();
            driver.FindElement(By.CssSelector(".custom-checkbox:nth-child(3) > .custom-control-label")).Click();
            driver.FindElement(By.Id("currentAddress")).SendKeys("spring avenue 1234");
            Thread.Sleep(4000);
            driver.Quit();
        }
    }
}