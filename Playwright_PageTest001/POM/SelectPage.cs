using Microsoft.Playwright;

namespace Playwright_PageTest001
{
    public class SelectPage
    {
        private readonly IPage _page;
        private readonly ILocator selectRbtn;
        private readonly ILocator continueBtn;

        public SelectPage(IPage page)
        {
            _page = page;
            selectRbtn = _page.Locator("#radiobutton_2");
            continueBtn = _page.Locator("#continue");
        }

        public async Task SelectHotel()
        {
            await selectRbtn.ClickAsync();
            await continueBtn.ClickAsync();
        }
    }
}