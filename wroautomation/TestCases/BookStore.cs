using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using wroautomation.Config;

namespace wroautomation
{
    public class BookStore
    {
        public void book_storetest(IWebDriver driver)
        {
            {
                bool waitForm1 = WaitHandler.ElementIsPresent(driver, By.Id("gotoStore"));
                if (waitForm1)
                {
                    driver.FindElement(By.Id("gotoStore")).Click();
                }
                else
                {
                    driver.FindElement(By.XPath("//*[@id=\"gotoStore\"]")).Click();
                }

                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//*[@id=\"see-book-Git Pocket Guide\"]")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div[2]/div[2]/div[2]/div[9]/div[2]")).Click();
                WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));//alert1
                IAlert alert1 = wait1.Until(ExpectedConditions.AlertIsPresent());
                string alertText1 = alert1.Text;
                Console.WriteLine("Book added to your collection." + alertText1);
                Thread.Sleep(1000);
                alert1.Accept();
                Actions actions = new Actions(driver);
                actions.SendKeys(Keys.PageDown).Perform();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(".show #item-3 > .text")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("(//button[contains(.,'Delete All Books')])[1]")).Click();
                driver.FindElement(By.Id("closeSmallModal-ok")).Click();
                WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));//alert2
                IAlert alert2 = wait2.Until(ExpectedConditions.AlertIsPresent());
                string alertText2 = alert2.Text;
                Console.WriteLine("Book deleted." + alertText2);
                Thread.Sleep(1000);
                alert2.Accept();
                Thread.Sleep(4000);
                driver.Quit();
            }
        }
    }
}