using System;
using OpenQA.Selenium;

namespace ProjetoSelenium.TestUI.PageObjects
{
    public class RegistroPO
    {
        private IWebDriver driver;
        private By byFormRegistro;
        private By byInputNome;
        private By byInputEmail;
        private By byInputSenha;
        private By byInputConfirmSenha;
        private By byBotaoRegistro;
        private By bySpanErroEmail;

        public string EmailMensagemErro => driver.FindElement(bySpanErroEmail).Text;

        public RegistroPO(IWebDriver driver)
        {
            //meu registro depende do iWebDriver
            this.driver = driver;
            byFormRegistro = By.TagName("form");
            byInputNome = By.Id("Nome");
            byInputEmail = By.Id("Email");
            byInputSenha = By.Id("Password");
            byInputConfirmSenha = By.Id("ConfirmPassword");
            byBotaoRegistro = By.Id("botaoRegistro");
            bySpanErroEmail = By.CssSelector("span.msg-erro[data-valmsg-msg-for-Email");

        }
        
        public void Visitar()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
        }

        public  void SubmeteFormulario()
        {
            driver.FindElement(byBotaoRegistro).Click();
        }

        public void PreencheFormulario(string nome,
         string email,
         string senha,
         string confirmsenha)
        {
        driver.FindElement(byInputNome).SendKeys(nome);
        driver.FindElement(byInputEmail).SendKeys(email);
        driver.FindElement(byInputSenha).SendKeys(senha);
        driver.FindElement(byInputConfirmSenha).SendKeys(confirmsenha);
        }
    }
}