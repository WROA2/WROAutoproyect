using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace wroautomation.Automation
{
    public class Program
    {
        private IWebElement element;
        private IWebDriver driver;

        [Test]
        public void LoginPage()
        {
            //Inicializacion del Driver
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/login");
            driver.Manage().Window.Maximize();
            //Creacion de objetos de cada clase (interfaz de usuario)
            Login objlogin = new Login();
            //Uso de los metodos creados dentro de cada clase
            objlogin.LoginTest(driver);
        }

        [Test]
        public void Formulario()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/login");
            driver.Manage().Window.Maximize();
            
            Login objlogin = new Login();
            Formulario objformulario = new Formulario();

            objlogin.LoginTest(driver);
            objformulario.Formulariotest(driver);
        }

        [Test]
        public void book_store()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/login");
            driver.Manage().Window.Maximize();

            Login objlogin = new Login();
            book_store objbook_store = new book_store();

            objlogin.LoginTest(driver);
            objbook_store.book_storetest(driver);
        }

        //wait handler
        public static bool ElementIsPresent(IWebDriver driver, By locator)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                wait.Until(dvr => dvr.FindElement(locator));
                return true;
            }
            catch (WaitHandleCannotBeOpenedException e)
            {
                return false;
            }
        }
    }
}
