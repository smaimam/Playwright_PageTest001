using Microsoft.Playwright;
using NUnit.Allure.Attributes;

namespace Playwright_PageTest001
{
    public class SelectScreen
    {
        private readonly IPage _page;
        private readonly ILocator selectRbtn;
        private readonly ILocator continueBtn;

        public SelectScreen(IPage page)
        {
            _page = page;
            selectRbtn = _page.Locator("#radiobutton_2");
            continueBtn = _page.Locator("#continue");
        }

       [AllureStep("Select Hotel Creek and Continue")]
        public async Task SelectHotel()
        {
            await selectRbtn.ClickAsync();
            await continueBtn.ClickAsync();

            await Screenshot.TakeScreenshot(_page, "Select Hotel Performed Successfully");

        }
    }
}