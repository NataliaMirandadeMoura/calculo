using OpenQA.Selenium;
using System;

namespace ConversorDistancias.Testes.Pages
{
    public class PageBase : IDisposable
    {
        protected IWebDriver _driver;

        public PageBase(IWebDriver driver)
        {
            _driver = driver;
        }

        private void Fechar()
        {
            _driver.Quit();
            _driver = null;
        }

        public void Dispose()
        {
            Fechar();
        }
    }
}
