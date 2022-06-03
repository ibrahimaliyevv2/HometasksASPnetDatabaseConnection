using Microsoft.AspNetCore.Mvc;

namespace EternaWithDatabase.Controllers
{
    public class PortFolioController : Controller
    {
        public IActionResult Portfolio()
        {
            return View();
        }
    }
}