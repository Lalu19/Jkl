using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class FoodProviderLoginController : Controller
    {
        public IActionResult FPLoginCreate()
        {
            return View();
        }
        public IActionResult FPLoginList()
        {
            return View();
        }

        public IActionResult FPLoginEdit(int foodProviderLoginId)
        {
            ViewBag.foodProviderLoginId = foodProviderLoginId;
            return View();
        }

        public IActionResult SAFPLoginCreate()
        {
            return View();
        }
        public IActionResult SAFPLoginList()
        {
            return View();
        }
    }
}
