using Microsoft.AspNetCore.Mvc;

namespace ElnetAct2.Controllers
{ 
    public class CineEase : Controller
    {

        [HttpGet]
        public IActionResult Home()
        {
            return PartialView();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return PartialView();
        }
    }
}
