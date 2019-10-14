using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using TechTalk.SpecFlow;

namespace UnitTestProject1
{
    [Binding]
    public class DemoSteps
    {

        private RemoteWebDriver _driver;

        public DemoSteps(RemoteWebDriver driver) => _driver = driver;

        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            var htmlReporter = new ExtentHtmlReporter(@"C:\reports\ExtentReport.html");
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            var feature = extent.CreateTest<Feature>("Demo");

            var scenario = feature.CreateNode<Scenario>("User Details form entry verification");

            scenario.CreateNode<Given>("I navigate to application");
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl("http://executionautomation.com/demosite/Login.html");
        }
        
        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I start entering user form details like")]
        public void GivenIStartEnteringUserFormDetailsLike(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I click submit button")]
        public void GivenIClickSubmitButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I verify the entered user form details in the application database")]
        public void GivenIVerifyTheEnteredUserFormDetailsInTheApplicationDatabase(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
