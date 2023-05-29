using Microsoft.Playwright;

namespace Playwright_PageTest001
{
    public class BookingPage
    {
        private readonly IPage _page;
        private readonly ILocator fname;
        private readonly ILocator lname;
        private readonly ILocator address;
        private readonly ILocator cc_num;
        private readonly ILocator cc_type;
        private readonly ILocator cc_exp_month;
        private readonly ILocator cc_exp_year;
        private readonly ILocator cc_cvv;
        private readonly ILocator book_now;

        public BookingPage(IPage page)
        {
            _page = page;
            fname = _page.Locator("#first_name");
            lname = _page.Locator("#last_name");
            address = _page.Locator("#address");
            cc_num = _page.Locator("#cc_num");
            cc_type = _page.Locator("#cc_type");
            cc_exp_month = _page.Locator("#cc_exp_month");
            cc_exp_year = _page.Locator("#cc_exp_year");
            cc_cvv = _page.Locator("#cc_cvv");
            book_now = _page.Locator("#book_now");
        }

        public async Task BooktHotel(string fn, string ln, string add, string cc_n, string cc_t, string cc_e_month, string cc_e_year, string cvv)
        {
            await fname.FillAsync(fn);
            await lname.FillAsync(ln);
            await address.FillAsync(add);
            await cc_num.FillAsync(cc_n);
            await cc_type.TypeAsync(cc_t);
            await cc_exp_month.TypeAsync(cc_e_month);
            await cc_exp_year.TypeAsync(cc_e_year);
            await cc_cvv.TypeAsync(cvv);
            await book_now.ClickAsync();
        }
    }
}