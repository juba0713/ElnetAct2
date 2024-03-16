using Microsoft.AspNetCore.Mvc;

namespace ElnetAct2.Controllers
{
    public class CineEase : Controller
    {
   
        public IActionResult Home()
        {
            return PartialView();
        }
    }
}
