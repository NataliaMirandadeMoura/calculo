using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Internal.Execution;
using System;

namespace Report
{
    [TestFixture]
    public class Reports
    {

        [Test]
        public void ExtentTestCase()
        {
            var htmlReporter = new ExtentHtmlReporter("extentReporter.html");
            var extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

            extent.AddSystemInfo("Operating System:", "Windows 10");
            extent.AddSystemInfo("HostName: ", "SeleniumPC");
            extent.AddSystemInfo("Browser:", "Google Chrome");

            var test = extent.CreateTest("ExtentTestCase");
            test.Log(Status.Info, "Step 1: Test case starts");
            test.Log(Status.Info, "Step 2: Test case for Pass");
            test.Log(Status.Info, "Step 3: test case failed");
            test.Pass("Screenshot", MediaEntityBuilder.CreateScreenCaptureFromPath("screenshot.png").Build());
            test.Pass("Screenshot").AddScreenCaptureFromPath("screenshot.png");
            extent.Flush();



        }
    }
}
