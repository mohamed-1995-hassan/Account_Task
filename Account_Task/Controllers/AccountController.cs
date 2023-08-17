using Microsoft.AspNetCore.Mvc;

namespace Account_Task.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
