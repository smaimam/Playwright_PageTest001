
using Allure.Net.Commons;
using Microsoft.Playwright;

namespace Playwright_PageTest001
{
    public class Screenshot
    {
        public static async Task TakeScreenshot(IPage page, string stepDetail, Status status = Status.passed)
        {
            byte[] bytes = await page.ScreenshotAsync();
            AllureLifecycle.Instance.AddAttachment(stepDetail, "image/png", bytes);
        }
    }
}