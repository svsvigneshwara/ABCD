using Microsoft.AspNetCore.Antiforgery;
using MOD.Controllers;

namespace MOD.Web.Host.Controllers
{
    public class AntiForgeryController : MODControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
