using Microsoft.AspNetCore.Mvc;

namespace WebIdentity.Controllers
{
    public class AuthorizeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
