using Microsoft.Playwright;
using NUnit.Allure.Attributes;

namespace Playwright_PageTest001
{
    public class LoginScreen
    {
        private readonly IPage _page;
        private readonly ILocator usernameTxt;
        private readonly ILocator passwordTxt;
        private readonly ILocator loginBtn;

        public LoginScreen(IPage page)
        {
            _page = page;
            usernameTxt = _page.Locator("#username");
            passwordTxt = _page.Locator("#password");
            loginBtn = _page.Locator("#login");
        }

        [AllureStep("Login with url{0} user {1} and password {2}")]
        public async Task Login(string url, string user, string pass)
        {
            await _page.GotoAsync(url);
            await usernameTxt.FillAsync(user);
            await passwordTxt.FillAsync(pass);
            await loginBtn.ClickAsync();

            await Screenshot.TakeScreenshot(_page, "Login Performed Successfully");
        }
    }
}