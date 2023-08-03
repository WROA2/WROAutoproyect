using NUnit.Framework;
using OpenQA.Selenium;

namespace wroautomation.Automation
{
    public class Login
    {
        public void LoginTest(IWebDriver driver)//se debe enviar en el metodo el driver para que úede enviar los elementos dentro del chrome
        {
            driver.FindElement(By.Id("userName")).Click();
            driver.FindElement(By.Id("userName")).SendKeys("QA1Automation1");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys("*ghjUtW1qC");
            driver.FindElement(By.Id("login")).Click();
        }
    }
}
