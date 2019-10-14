using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using Selenium.Utils;

namespace ConversorDistancias.Testes.Pages
{
    public class PesquisaGoogle : PageBase
    {
        private readonly IConfiguration _configuration;

        public PesquisaGoogle(BrowserContext browserContext)
            : base(browserContext.WebDriver)
        {
            _configuration = browserContext.Configuration;
        }

        public bool AcharBotao()
        {
            string botao = _driver.GetText(
                 By.CssSelector("#gb > div > div.gb_Zc > a")).ToString();

            return !string.IsNullOrEmpty(botao);
        }
    }
}
