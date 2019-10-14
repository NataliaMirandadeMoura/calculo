using BoDi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Remote;

namespace UnitTestProject1
{
    [Binding]
    public class Hooks
    {
        private readonly IObjectContainer _objectContainer;

        private RemoteWebDriver _driver;

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

      
        [AfterScenario]
        public void CleanUp()
        {
            _driver.Quit();
        }

       

    }
}
