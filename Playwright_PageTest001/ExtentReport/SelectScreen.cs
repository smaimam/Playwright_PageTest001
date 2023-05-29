using Microsoft.Playwright;

namespace Playwright_PageTest001
{
    public class SelectHotel
    {
        private readonly IPage _page;
        private readonly ILocator selectRbtn;
        private readonly ILocator continueBtn;

        public SelectHotel(IPage page)
        {
            _page = page;
            selectRbtn = _page.Locator("#radiobutton_2");
            continueBtn = _page.Locator("#continue");
        }

        public async Task Select()
        {
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Select Hotel");

            await selectRbtn.ClickAsync();
            await continueBtn.ClickAsync();

            await ExtentReport.TakeScreenshot(_page, "Select Hotel Performed Successfully");

        }
    }
}