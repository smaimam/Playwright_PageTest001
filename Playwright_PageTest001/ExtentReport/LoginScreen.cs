using Microsoft.Playwright;


namespace Playwright_PageTest001
{
    public class LoginHotel
    {
        private readonly IPage _page;
        private readonly ILocator usernameTxt;
        private readonly ILocator passwordTxt;
        private readonly ILocator loginBtn;

        public LoginHotel(IPage page)
        {
            _page = page;
            usernameTxt = _page.Locator("#username");
            passwordTxt = _page.Locator("#password");
            loginBtn = _page.Locator("#login");
        }

        public async Task Login(string url, string user, string pass)
        {
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Login Hotel");
            await _page.GotoAsync(url);
            await usernameTxt.FillAsync(user);
            await passwordTxt.FillAsync(pass);
            await loginBtn.ClickAsync();

            await ExtentReport.TakeScreenshot(_page, "Login Performed Successfully");
        }
    }
}