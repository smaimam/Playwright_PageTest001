using Microsoft.Playwright;
using NUnit.Allure.Attributes;

namespace Playwright_PageTest001
{
    public class SearchScreen
    {
        private readonly IPage _page;
        private readonly ILocator locationDd;
        private readonly ILocator hotelsDd;
        private readonly ILocator roomTypeDd;
        private readonly ILocator noOfRoomDd;
        private readonly ILocator checkinDateTxt;
        private readonly ILocator checkoutDateTxt;
        private readonly ILocator adultPerRoomDd;
        private readonly ILocator searchBtn;


        public SearchScreen(IPage page)
        {
            _page = page;
            locationDd = _page.Locator("#location");
            searchBtn = _page.Locator("#Submit");
        }

       [AllureStep("Search Hotel using Location")]
        public async Task Search(string location)
        {
            await locationDd.TypeAsync(location);
            await searchBtn.ClickAsync();

            await Screenshot.TakeScreenshot(_page, "Search Hotel Performed Successfully");

        }
    }
}