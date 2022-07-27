using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Upload()
        {
            return View();
        }
    }
}
