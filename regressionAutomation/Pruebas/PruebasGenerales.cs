using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using regressionAutomation.Configuraciones;
using regressionAutomation.Implementaciones;

namespace regressionAutomation.Pruebas
{
    public class Pruebas : Base
    {
        readonly string url = Entorno.url_web;

        [SetUp]
        public void start_Browser()
        {
            driver.Manage().Window.Maximize();
            driver.Url = url;
            Thread.Sleep(5000);
        }

        [Test]
        public void pruebaVerificarElemento()
        {
            Verificationes.VerificarElementoExiste("Elements");
            Verificationes.VerificarElementoExiste("Forms");
            Verificationes.VerificarElementoExiste("Alerts, Frame & Windows");
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }
    }
}