using Microsoft.Playwright.NUnit;

namespace Playwright_PageTest001
{
    [TestFixture]
    public class TestExecution : PageTest
    {
        [Test]
        public async Task LoginExecution_TC()
        {
            LoginPage loginPage = new LoginPage(Page);
            await loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
        }

        [Test]
        public async Task SearchHotelExecution_TC()
        {
            LoginPage loginPage = new LoginPage(Page);
            SearchPage searchPage = new SearchPage(Page);

            await loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
            await searchPage.SearchHotel("Sydney");
        }

        [Test]
        public async Task BookHotelExecution_TC()
        {
            LoginPage loginPage = new LoginPage(Page);
            SearchPage searchPage = new SearchPage(Page);
            SelectPage selectPage = new SelectPage(Page);
            BookingPage bookingPage = new BookingPage(Page);

            await loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
            await searchPage.SearchHotel("Sydney");
            await selectPage.SelectHotel();
            await bookingPage.BooktHotel("Amir", "Imam", "123 Street", "1234567890123456", "VISA", "2", "2025", "123");
        }
    }
}