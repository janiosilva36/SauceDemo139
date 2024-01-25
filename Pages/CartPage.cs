using OpenQA.Selenium;

namespace Pages
{
    public class CartPage : CommonPage
    {
        // Mapeamento de Elementos

       
        private IWebElement lblQuantidade => driver.FindElement(By.CssSelector("div.cart_quantity"));
        private IWebElement lblNomeProduto => driver.FindElement(By.CssSelector("div.inventory_item_name")); 
        private IWebElement lblPreco => driver.FindElement(By.CssSelector("div.inventory_item_price"));

         // Construtor
         public CartPage(IWebDriver driver) : base(driver){}

        // Ações
        public String LerQuantidade()
        {
            return lblQuantidade.Text;
        }
        public String LerNomeProduto()
        {
            return lblNomeProduto.Text;
        }
        public String LerPreco()
        {
            return lblPreco.Text;
        }

    }
}