using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class DietTypeController : Controller
    {
        public IActionResult DietTypeCreate()
        {
            return View();
        }
        public IActionResult DietTypeList()
        {
            return View();
        }
        public IActionResult DietTypeEdit(int dietTypeId)
        {
            ViewBag.dietTypeId = dietTypeId;
            return View();
        }
    }
}
