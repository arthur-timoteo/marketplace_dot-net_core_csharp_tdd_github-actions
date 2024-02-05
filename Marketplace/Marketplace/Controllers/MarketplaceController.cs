using Microsoft.AspNetCore.Mvc;

namespace Marketplace.Controllers
{
    public class MarketplaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }
    }
}
