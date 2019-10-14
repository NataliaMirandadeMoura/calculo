using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using ConversorDistancias.Pages.Testes;
using ConversorDistancias.Testes.Pages;
using Microsoft.Extensions.Configuration;
using Selenium.Utils;
using System;
using System.IO;
using Xunit;

namespace ConversorDistancias.Testes
{
    public class GoogleTestes
    {
        private IConfiguration _configuration;


        public GoogleTestes()
        {
            var path = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory());

            var builder = path
                .AddJsonFile($"appsettings.json");

            _configuration = builder.Build();
        }

        [Theory]
        [InlineData(Browser.Chrome, "Google")]
        [InlineData(Browser.Chrome, "Google1")]
        [InlineData(Browser.Chrome, "Google2")]
        public void TestarPesquisaNoGoogle(
            Browser browser, string texto)
        {
            var browserContext = new BrowserContext(browser, _configuration);



            using (var tela1 = new GooglePage(browserContext))
            using (var tela2 = new PesquisaGoogle(browserContext))
            {
                tela1.CarregarPagina();
                tela1.PreencheCampoDeTexto(texto);
                tela1.SubmiterAPesquisa();

                Assert.True(tela2.AcharBotao());
            }

          


        }
    }
}
