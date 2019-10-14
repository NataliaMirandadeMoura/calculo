using ConversorDistancias.Testes.Pages;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.Utils;
using System;

namespace ConversorDistancias.Pages.Testes
{
    public class GooglePage : PageBase
    {
        private readonly IConfiguration _configuration;

        public GooglePage(BrowserContext browserContext)
            : base(browserContext.WebDriver)
        {
            _configuration = browserContext.Configuration;
        }

        public void CarregarPagina()
        {
            _driver.LoadPage(
                TimeSpan.FromSeconds(5),
                _configuration.GetSection("Selenium:UrlTelaConversaoDistancias").Value);
        }

        public void PreencheCampoDeTexto(string texto)
        {
            _driver.SetText(
                By.Name("q"),
                texto.ToString());
        }

        public void SubmiterAPesquisa()
        {
            WebDriverWait wait = _driver.Wait(10);

            wait.Until().NameAppears("btnK");

            _driver.Submit(By.Name("btnK"));
        }

        public bool AcharBotao()
        {
            string botao = _driver.GetText(
                 By.CssSelector("#gb > div > div.gb_Zc > a")).ToString();

            return !string.IsNullOrEmpty(botao);
        }
    }
}

