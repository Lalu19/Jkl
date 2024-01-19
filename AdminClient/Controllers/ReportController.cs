using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult DeliveryReport()
        {
            return View();
        }
    }
}
