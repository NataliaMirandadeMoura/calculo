using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtentReport
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ExtentTestCase()
        {
            var htmlReporter = new ExtentHtmlReporter("extentReporter.html");
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            extent.AddSystemInfo("Operating System:", "Windows 10");
            extent.AddSystemInfo("Host Name:", "SeleniumPC");
            extent.AddSystemInfo("Browser: ", "Google Chrome");

            var test = extent.CreateTest("ExtentTestCase");
            test.Log(Status.Info, "Step 1: Test case starts");
            test.Log(Status.Pass, "Step 2: Test case for Pass");
            test.Log(Status.Fail, "Step 3: Test case for failed");
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath("screenshot.png").Build());
            test.Pass("Screenshoot").AddScreenCaptureFromPath("screenshot.png");

            extent.Flush();

        }
    }
}
