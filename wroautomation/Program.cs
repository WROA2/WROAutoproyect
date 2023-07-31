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
            LoginPage();
            //Creacion de objetos de cada clase (interfaz de usuario)
            Formulario objformulario = new Formulario();
            //Uso de los metodos creados dentro de cada clase
            objformulario.Formulariotest(driver);

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
