using Allure.Net.Commons;
using Microsoft.Playwright.NUnit;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace Playwright_PageTest001
{
    [TestFixture]
    [AllureNUnit]
    public class TestExecutionAllure : PageTest
    {
        [SetUp]
        [AllureBefore("Test Init")]
        public async Task Setup()
        {
            Console.WriteLine("Test Setup");
            await Screenshot.TakeScreenshot(Page, "Test Init Setup");
        }

        [TearDown]
        [AllureAfter("Test Clean")]
        public async Task TearDown()
        {
            Console.WriteLine("Test Cleanup");
            await Screenshot.TakeScreenshot(Page, "Test Clean Method");
            await Page.CloseAsync();
        }

        [Test]
        [AllureStep]
        [AllureEpic("Hotel EPIC")]
        [AllureFeature("Core Feature")]
        [AllureStory("Booking Hotel User Story")]
        [AllureOwner("Amir Imam")]
        [AllureDescription("This is for demo purpose")]
        [Category("Allure")]
        [AllureTag("NUnit", "Debug", "Booking")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureId(123)]
        [AllureTms("Defect 54 ", "https://dev.azure.com/DemoOrganizationAI/DemoAgileProject/_workitems/edit/54")]
        [AllureSuite("Booking Suite")]
        [AllureLink("TestCase 38", "https://dev.azure.com/DemoOrganizationAI/DemoAgileProject/_workitems/edit/38")]
        public async Task Allure_BookHotelExecution_TC()
        {
            LoginScreen loginPage = new LoginScreen(Page);
            SearchScreen searchPage = new SearchScreen(Page);
            SelectScreen selectPage = new SelectScreen(Page);
            BookingScreen bookingPage = new BookingScreen(Page);

            await loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
            await searchPage.Search("Sydney");
            await selectPage.SelectHotel();
            await bookingPage.BookHotel("Amir", "Imam", "123 Street", "1234567890123456", "VISA", "2", "2025", "123");
        }

        [Test]
        [AllureStep("Login with valid user and pass")]
        [Category("Allure")]
        [AllureSuite("Login Suite")]
        public async Task Allure_Login_TC()
        {
            LoginPage loginPage = new LoginPage(Page);
            await loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
        }
         
        [Test]
        [AllureStep]
        [AllureStory("Search User Story")]
        [AllureOwner("Amir Imam")]
        [AllureDescription("This is for demo purpose")]
        [AllureTag("Login", "Search")]
        [Category("Allure")]
        [AllureSuite("Search Suite")]
        public async Task Allure_SearchHotelExecution_TC()
        {
            LoginScreen loginPage = new LoginScreen(Page);
            SearchScreen searchPage = new SearchScreen(Page);

            await loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
            await searchPage.Search("Sydney");
        }

        [Test]
        [AllureStep]
        [AllureStory("Select User Story")]
        [AllureOwner("Amir Imam")]
        [AllureDescription("This is for demo purpose")]
        [Category("Allure")]
        public async Task Allure_SelectHotelExecution_TC()
        {
            LoginScreen loginPage = new LoginScreen(Page);
            SearchScreen searchPage = new SearchScreen(Page);
            SelectScreen selectPage = new SelectScreen(Page);

            await loginPage.Login("https://adactinhotelapp.com/", "AmirImam", "AmirImam");
            await searchPage.Search("Sydney");
            await selectPage.SelectHotel();
        }

       
    }
}