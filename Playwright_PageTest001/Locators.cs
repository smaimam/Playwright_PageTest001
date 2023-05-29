using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using System.Text.RegularExpressions;

namespace Playwright_PageTest001
{
    [TestFixture]
    public class Locators : PageTest
    {
        [Test]
        public async Task Test1()
        {
            await Page.GotoAsync("https://adactinhotelapp.com/");
            await Expect(Page).ToHaveTitleAsync(new Regex("Adactin.com - Hotel Reservation System"));
            await Page.FillAsync("#username", "AmirImam");
            await Page.FillAsync("#password", "AmirImam");
            await Page.ClickAsync("#login");
            await Expect(Page).ToHaveTitleAsync(new Regex("Adactin.com - Search Hotel"));
        }

        [Test]
        public async Task GetByPlaceHolder()
        {
            await Page.GotoAsync("https://demoqa.com/text-box");
            await Page.GetByPlaceholder("Full Name").FillAsync("Tester1");
            await Page.GetByPlaceholder("name@example.com").FillAsync("Amir@imam.com");
            await Page.GetByPlaceholder("Current Address").FillAsync("Abc/1 Area");
        }

        [Test]
        public async Task GetByText()
        {
            await Page.GotoAsync("https://demoqa.com/links");
            await Page.GetByText("Created").ClickAsync();
        }

        [Test]
        public async Task GetByAltText()
        {
            await Page.GotoAsync("https://playwright.dev/dotnet/docs/locators#locate-by-alt-text");
            await Page.GetByAltText("playwright logo").First.ClickAsync();
        }

        [Test]
        public async Task GetByLabel()
        {
            await Page.GotoAsync(@"https://playwright.dev/dotnet/docs/locators#locate-by-title");
            await Page.GetByLabel("Password").FillAsync("secret112233");
            Thread.Sleep(5000);
        }

        [Test]
        public async Task GetByTitle()
        {
            await Page.GotoAsync("https://playwright.dev/dotnet/docs/locators#locate-by-title");
            await Expect(Page.GetByTitle("Issues count")).ToHaveTextAsync("25 issues");
        }

        [Test]
        public async Task GetByRole()
        {
            await Page.GotoAsync("https://playwright.dev/dotnet/docs/locators#locate-by-role");
            await Page.SetViewportSizeAsync(width: 1920, height: 1080);

            await Expect(Page
               .GetByRole(AriaRole.Heading, new() { Name = "Sign up" }))
               .ToBeVisibleAsync();

            await Page
                .GetByRole(AriaRole.Checkbox, new() { Name = "Subscribe" })
                .CheckAsync();

            await Page
                .GetByRole(AriaRole.Button, new()
                {
                    NameRegex = new Regex("submit", RegexOptions.IgnoreCase)
                })
                .ClickAsync();
        }

        [Test]
        public async Task GetByTestId()
        {
            await Page.GotoAsync("https://playwright.dev/dotnet/docs/locators#locate-by-test-id");
            await Page.GetByTestId("directions").ClickAsync();
        }
    }
}