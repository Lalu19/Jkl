using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class FoodServiceTypeController : Controller
    {
        public IActionResult FoodServiceTypeCreate()
        {
            return View();
        }
        public IActionResult FoodServiceTypeList()
        {
            return View();
        }
        public IActionResult FoodServiceTypeEdit(int foodServiceTypeId)
        {
            ViewBag.foodServiceTypeId = foodServiceTypeId;
            return View();
        }
    }
}
