using OpenQA.Selenium;
using ProjetoSelenium.TestUI.Fixtures;
using ProjetoSelenium.TestUI.PageObjects;
using Xunit;

namespace ProjetoSelenium.TestUI.Testes
{
    [Collection("Chrome Driver")]
    public class AoEfetuarRegistro
    {
            private IWebDriver driver;
           
            public AoEfetuarRegistro(TestFixture fixture)
            {
                driver = fixture.Driver;
            }

            [Fact]
            public void DadoInfoValidasDeveIrParaPaginaDeAgradecimento()
            {
            //arrange - dado chrome aberto, pagina inicial do sistema de leilao
            //dados de registros validos informados
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            //capturando elementos
            var inputNome = driver.FindElement(By.Id("Nome"));
            var inputEmail = driver.FindElement(By.Id("Email"));
            var inputSenha = driver.FindElement(By.Id("Password"));
            var inputConfirmSenha = driver.FindElement(By.Id("ConfirmPassword"));
            //botao de registro
            var botaoRegistro = driver.FindElement(By.Id("btnRegistro"));
            inputNome.SendKeys("Murilo Eduardo");
            inputEmail.SendKeys("muriloeduardo1997@outlook.com");
            inputSenha.SendKeys("1212");
            inputConfirmSenha.SendKeys("1212");

            //act - efetuo o registro 
            botaoRegistro.Click();
            //assert - devo ser direcionado para uma página de agradecimento
            Assert.Equal("Obrigado", driver.PageSource);
            }

            [Theory]
            [InlineData("","muriloeduardo1997@outlook.com","1234","1234")]
            [InlineData("Murilo Eduardo","muriloeduardo199","1234","1234")]
            [InlineData("Murilo Eduardo","muriloeduardo1997@outlook.com","1234","1414")]
            [InlineData("Murilo Eduardo","muriloeduardo1997@outlook.com","1234","")]
             public void DadoInfoInvalidaDeveContinuarNaHome(
                 string nome, string email, string senha, string confirmsenha)
            {
            //arrange - dado chrome aberto, pagina inicial do sistema de leilao
            //dados de registros validos informados
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            //capturando elementos
            var inputNome = driver.FindElement(By.Id("Nome"));
            var inputEmail = driver.FindElement(By.Id("Email"));
            var inputSenha = driver.FindElement(By.Id("Password"));
            var inputConfirmSenha = driver.FindElement(By.Id("ConfirmPassword"));
            var botaoRegistro = driver.FindElement(By.Id("btnRegistro"));
            inputNome.SendKeys(nome);
            inputEmail.SendKeys(email);
            inputSenha.SendKeys(senha);
            inputConfirmSenha.SendKeys(confirmsenha);

            //act - efetuo o registro 
            botaoRegistro.Click();
            //assert - devo ser direcionado para uma página de agradecimento
            Assert.Equal("section-registro", driver.PageSource);
            }

            [Fact]
            public void DadoNomeEmBrancoDeveMostrarMensagemDeErro()
            {
            //arrange
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            //botao de registro
            var botaoRegistro = driver.FindElement(By.Id("btnRegistro"));

            //act - efetuo o registro 
            botaoRegistro.Click();
            //asert
            //capturando elemento de texto da mensagem
            IWebElement elemento = driver.FindElement(By.CssSelector("span.msg-erro[data-valmsg-msg-for-nome"));
            Assert.Equal("The nome field is required", elemento.Text);
            //será que ele ta sendo exibido?
            }

              [Fact]
            public void DadoEmailInvalidoDeveMostrarMensagemDeErro()
            {
            var registroPO = new RegistroPO(driver);
            registroPO.Visitar();
            registroPO.PreencheFormulario(nome:"null",
            email:"murilo",
            senha:"",
            confirmsenha:"");
            
            //act  
            registroPO.SubmeteFormulario();            
            
            //asert
            Assert.Equal("The email field is required", registroPO.EmailMensagemErro);
            //será que ele ta sendo exibido?
            }
        }
    }
