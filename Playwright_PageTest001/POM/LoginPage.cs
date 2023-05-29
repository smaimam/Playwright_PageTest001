using Microsoft.Playwright;
using NUnit.Allure.Attributes;

namespace Playwright_PageTest001
{
    public class LoginPage
    {
        private readonly IPage _page;
        private readonly ILocator usernameTxt;
        private readonly ILocator passwordTxt;
        private readonly ILocator loginBtn;

        public LoginPage(IPage page)
        {
            _page = page;
            usernameTxt = _page.Locator("#username");
            passwordTxt = _page.Locator("#password");
            loginBtn = _page.Locator("#login");
        }

        public async Task Login(string url, string user, string pass)
        {
            await _page.GotoAsync(url);
            await usernameTxt.FillAsync(user);
            await passwordTxt.FillAsync(pass);
            await loginBtn.ClickAsync();
        }
    }
}