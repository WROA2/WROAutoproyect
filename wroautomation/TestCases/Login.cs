using OpenQA.Selenium;
using System;


namespace wroautomation
{
    public class Login
    {
            public void LoginTest(IWebDriver driver) //se debe enviar en el metodo el driver para que pueda enviar los elementos dentro del chrome
        {
            string value = Environment.GetEnvironmentVariable("wra");
            driver.FindElement(By.Id("userName")).Click();
            driver.FindElement(By.Id("userName")).SendKeys("QA1Automation1");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).SendKeys(value);
            driver.FindElement(By.Id("login")).Click();
        }
    }
}
