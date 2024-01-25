// Bibliotecas
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


// Namespace

namespace StepDefinitionsPO
{
    [Binding] // Marcação que a classe segue o padrão SpecFlow

    public class Hooks
    {
        // Atributos / Objetos
        private ScenarioContext _ScenarioContext; // interno a classe
        private IWebDriver driver;

        // Métodos / Funções
        public Hooks(ScenarioContext scenarioContext)
        {  // Interno a classe    // Externo a classe
            _ScenarioContext = scenarioContext; 
        }

        [BeforeScenario]
        public void ScenarioSetup()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);
            driver.Manage().Window.Maximize();
            _ScenarioContext["driver"] = driver;
            Console.WriteLine("Iniciando: " + _ScenarioContext.ScenarioInfo.Title);
        }
        [AfterScenario]
        public void ScenarioTearDown()
        {
            driver = (IWebDriver) _ScenarioContext["driver"];
            driver.Quit();
        }

    }
}