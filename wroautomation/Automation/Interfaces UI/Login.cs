﻿using NUnit.Framework;
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
            //Thread.Sleep(3000);
            driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[1]/div/div/div[2]/span/div")).Click();
            bool waitform = Program.ElementIsPresent(driver, By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[2]/div/ul/li/span"));
            if (waitform)
            {
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[1]/div/div/div[2]/div/ul/li")).Click();
            }
            else
            {
                driver.FindElement(By.Id("item-0")).Click();
            }
            driver.FindElement(By.Id("firstName")).Click();
            driver.FindElement(By.Id("firstName")).SendKeys("test1");
            driver.FindElement(By.Id("lastName")).Click();
            driver.FindElement(By.Id("lastName")).SendKeys("qautomation");
            driver.FindElement(By.Id("userEmail")).Click();
            driver.FindElement(By.Id("userEmail")).SendKeys("test1qautomation@email.com");
            driver.FindElement(By.CssSelector(".custom-radio:nth-child(1)")).Click();
            driver.FindElement(By.CssSelector(".custom-radio:nth-child(1) > .custom-control-label")).Click();
            driver.FindElement(By.Id("userNumber")).Click();
            driver.FindElement(By.Id("userNumber")).SendKeys("920308800");
            driver.FindElement(By.CssSelector(".custom-checkbox:nth-child(1) > .custom-control-label")).Click();
            driver.FindElement(By.CssSelector(".custom-checkbox:nth-child(2) > .custom-control-label")).Click();
            driver.FindElement(By.CssSelector(".custom-checkbox:nth-child(3) > .custom-control-label")).Click();
            driver.FindElement(By.Id("currentAddress")).SendKeys("spring avenue 1234");



        }
    }
}
