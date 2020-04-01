using OpenQA.Selenium;
using ProjetoSelenium.TestUI.Fixtures;
using ProjetoSelenium.TestUI.PageObjects;
using Xunit;

namespace ProjetoSelenium.TestUI.Testes
{
    [Collection("Chrome Driver")]
    public class AoEfetuarLogin
    {
        private IWebDriver driver ;
        
        public AoEfetuarLogin(TestFixture fixture)
        {
            driver = fixture.Driver;
        }
        [Fact]
        public void DadoCredenciaisValidasDeveIrParaDashBoard()
        {
            //arrange
            var loginPO = new LoginPO(driver);
            loginPO.Visitar();
            loginPO.PreencheFormulario("fulano@example.org","123");

            //act
            loginPO.SubmeterFormulario();


            //assert
            Assert.Contains("Dashboard",driver.Title);
        }

        [Fact]
        public void DadoCrendenciaisInvalidasDeveContinuarLogin()
        {
                 //arrange
            var loginPO = new LoginPO(driver);
            loginPO.Visitar();
            loginPO.PreencheFormulario("fulano@example.org","");

            //act
            loginPO.SubmeterFormulario();


            //assert
            Assert.Contains("Login",driver.PageSource);
       
        }
    }
}