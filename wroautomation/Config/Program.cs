using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace wroautomation.Config
{
    public class Program
    {
        [Test]
        public void LoginPage()
        {
            //Inicializacion del Driver
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/login");
            driver.Manage().Window.Maximize();
            //Creacion de objetos de cada clase (interfaz de usuario)
            Login objLogin = new Login();
            //Uso de los metodos creados dentro de cada clase
            objLogin.LoginTest(driver);
        }

        [Test]
        public void Formulario()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/login");
            driver.Manage().Window.Maximize();
            
            Login objLogin = new Login();
            Formulario objFormulario = new Formulario();

            objLogin.LoginTest(driver);
            objFormulario.Formulariotest(driver);
        }

        [Test]
        public void book_store()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/login");
            driver.Manage().Window.Maximize();

            Login objLogin = new Login();
            BookStore objBookStore = new BookStore();

            objLogin.LoginTest(driver);
            objBookStore.book_storetest(driver);
        }
    }
}