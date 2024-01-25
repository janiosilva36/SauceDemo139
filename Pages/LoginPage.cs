// Bibliotecas

// Namespace
using OpenQA.Selenium;

namespace Pages
{
// Classe
    public class LoginPage : CommonPage
    {
    // Atributos
        // Mapeamento dos Elementos
        private IWebElement txtUsuario => driver.FindElement(By.Id("user-name"));
        private IWebElement txtSenha => driver.FindElement(By.Id("password"));
        private IWebElement btnLogin => driver.FindElement(By.Id("login-button"));


    // Métodos e Funções
        // Construtor
        public LoginPage(IWebDriver driver) : base(driver)
        {

        }
        // Ações a serem usadas na automoção
        public void PreencherUsuario(String usuario)
        {
            txtUsuario.SendKeys(usuario);
            
        }

        public void PreencherSenha(String senha)
        {
            txtUsuario.SendKeys(senha);
            
        }



        public void ClicarNoBotaoLogin()
        {
            btnLogin.Click();
        }

        public void DarEnter()
        {
                txtSenha.SendKeys(Keys.Enter);
        }

    }    

}