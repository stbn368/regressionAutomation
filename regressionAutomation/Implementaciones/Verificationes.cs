using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using regressionAutomation.Configuraciones;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace regressionAutomation.Implementaciones
{
    public class Verificationes : Base
    {
        public static void VerificarElementoExiste(string textoElemento)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Configuraciones.Tiempos.tiempo_EsperaImplicita));
            string localizador = "//*[text()='" + textoElemento + "']";

            try
            {
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(localizador)));
                var elementos = driver.FindElements(By.XPath(localizador));

                if (elementos.Count > 1)
                {
                    throw new MultipleElementsFoundException($"Se encontraron {elementos.Count} elementos, pero se esperaba solo uno.");
                }
                else
                {
                    Assert.IsTrue(elementos.Any(), "No se ha encontrado el elemento.");
                }
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Ocurrió una excepción inesperada: " + ex.Message);
                throw;
            }

            

        }
    }
}
