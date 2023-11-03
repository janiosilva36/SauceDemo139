using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace MyNamespace
{
    [Binding]
    public class StepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver driver;   // objeto do Selenium

        public StepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void SetUp()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();  //Instanciou o Selenium com Chrome
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(10000);
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void TearDown()
        {
            driver.Quit();
        }




        [Given(@"que acesso a pagina incial do site")]
        public void DadoQueAcessoAPaginaIncialDoSite()
        {
            _scenarioContext.Pending();
        }

        [When(@"preencho o usuario como ""(.*)""")]
        public void QuandoPreenchoOUsuarioComo(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"a senha ""(.*)"" e clico no botao Login")]
        public void QuandoASenhaEClicoNoBotaoLogin(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"adiciono o produto ""(.*)"" ao carrinho")]
        public void QuandoAdicionoOProdutoAoCarrinho(string p0)
        {
            _scenarioContext.Pending();
        }

        [When(@"clico no icone do carrinho de compras")]
        public void QuandoClicoNoIconeDoCarrinhoDeCompras()
        {
            _scenarioContext.Pending();
        }

        [Then(@"exibe ""(.*)"" no titulo da Selecao")]
        public void EntaoExibeNoTituloDaSelecao(string products0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"exibe a pagina do carrinho com a quantidade ""(.*)""")]
        public void EntaoExibeAPaginaDoCarrinhoComAQuantidade(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"nome do produto ""(.*)""")]
        public void EntaoNomeDoProduto(string p0)
        {
            _scenarioContext.Pending();
        }

        [Then(@"o preco como ""(.*)""")]
        public void EntaoOPrecoComo(string p0)
        {
            _scenarioContext.Pending();
        }
    }
}