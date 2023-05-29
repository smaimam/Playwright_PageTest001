using Microsoft.Playwright;

namespace Playwright_PageTest001
{
    public class SearchHotel
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


        public SearchHotel(IPage page)
        {
            _page = page;
            locationDd = _page.Locator("#location");
            searchBtn = _page.Locator("#Submit");
        }

        public async Task Search(string location)
        {
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Search Hotel");

            await locationDd.TypeAsync(location);
            await searchBtn.ClickAsync();

            await ExtentReport.TakeScreenshot(_page, "Search Hotel Performed Successfully");

        }
    }
}