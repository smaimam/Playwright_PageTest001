using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;
using Microsoft.Playwright;

namespace Playwright_PageTest001
{
    public class ExtentReport
    {
        public static ExtentReports extentReports;
        public static ExtentTest exParentTest;
        public static ExtentTest exChildTest;
        public static string dirpath;

        public static string pathWithFileNameExtension;
        private readonly IPage _page;

        public static void LogReport(string testcase)
        {
            extentReports = new ExtentReports();
            dirpath = @"C:\ExtentReports\" + "_" + testcase;

            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);
            htmlReporter.Config.Theme = Theme.Standard;
            extentReports.AttachReporter(htmlReporter);
        }

        public static async Task TakeScreenshot(IPage page, string stepDetail, Status status= Status.Pass)
        {
            string path = @"C:\ExtentReports\images\" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            pathWithFileNameExtension = @path + ".png";
            await page.Locator("body").ScreenshotAsync(new LocatorScreenshotOptions { Path = pathWithFileNameExtension });
            TestContext.AddTestAttachment(pathWithFileNameExtension);
            exChildTest.Log(status, stepDetail, MediaEntityBuilder
                .CreateScreenCaptureFromPath(path + ".png").Build());
        }
    }
}