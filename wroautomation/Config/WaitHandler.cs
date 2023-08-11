using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace wroautomation.Config
{
    public class WaitHandler
    {
        public static bool ElementIsPresent(IWebDriver driver, By locator)
        {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                wait.Until(dvr => dvr.FindElement(locator));
                return true;
            }
        }
    }