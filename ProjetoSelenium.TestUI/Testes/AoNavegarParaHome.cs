using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjetoSelenium.TestUI.Fixtures;
using ProjetoSelenium.TestUI.Helpers;
using Xunit;

namespace ProjetoSelenium.TestUI.Testes
{
    [Collection("Chrome Driver")]
    public class AoNavegarParaHome 
     {
        private  IWebDriver driver;

        //Setup
        public AoNavegarParaHome(TestFixture fixture)
        {
            driver = fixture.Driver;
        }
        [Fact]
        public void DadoChromeAbertoDeveMostrarLeiloesNoTitulo()
        {
            //arrange

            //act
            //quando  eu navegado para a url
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            //assert
            //espero o titulo do navegador tenha a palavra leilao
            Assert.Contains("Leilões", driver.Title);
        }
        [Fact]
        public void DadoChromeAbertoDeveMostrarProximosLeiloesNaPagina()
        {
            //act
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            //assert
            Assert.Contains("Próximos Leilões", driver.PageSource);
            //procura no codigo fonte da pagina
        }

         [Fact]
        public void DadoChromeAbertoFormRegistroNaoDeveMostrarMensagensDeErro()
        {
            //act
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            //assert
            //todos os spans de mensagen de erro não estão sendo exibidos
            var forms = driver.FindElement(By.TagName("form"));
            var spans = forms.FindElements(By.TagName("span"));
            foreach (var span in spans)
            {
                //ela precisa ser vazia visto que sempre é setada na tela
                Assert.True(string.IsNullOrEmpty(span.Text));
            }
        }
    }
}
