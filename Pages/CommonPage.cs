
using OpenQA.Selenium;

namespace Pages
{
    public class CommonPage
    {
        // Atributos

        protected IWebDriver driver;

        // Mapeamneto dos Elementos comuns a duas ou mais telas
        private IWebElement lblTituloSecao => driver.FindElement(By.CssSelector("span.title"));

        private IWebElement icoCarrinho => driver.FindElement(By.CssSelector("a.shopping_cart_link"));

        // Métodos e Funções
        // Construtor
        public CommonPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        // Ações 
        public String LerTituloDaSecao()
        {
            return lblTituloSecao.Text;
        }
        public void IrParaOCarrinho()
        {
            icoCarrinho.Click();
        }




    }

}