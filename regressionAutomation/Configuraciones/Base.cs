using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace regressionAutomation.Configuraciones
{
    public class Base
    {
        public static IWebDriver driver = new ChromeDriver();
    }
}
