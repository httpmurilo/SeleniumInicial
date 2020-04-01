using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ProjetoSelenium.TestUI.Helpers;

namespace ProjetoSelenium.TestUI.Fixtures
{
    public class TestFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }
        //Setup
        public TestFixture()
        {
            Driver = new ChromeDriver(TesteHelpers.PastaDoExecutavel);
        }
        //TearDown
        public void Dispose()
        {
            Driver.Quit();
        }

    }
}