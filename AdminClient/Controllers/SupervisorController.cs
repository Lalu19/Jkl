using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class SupervisorController : Controller
    {
        public IActionResult SupervisorCreate()
        {
            return View();
        }
        public IActionResult SupervisorList()
        {
            return View();
        }
        public IActionResult SupervisorEdit(int supervisorId)
        {
            ViewBag.supervisorId = supervisorId;
            return View();
        }

        public IActionResult SASupervisorCreate()
        {
            return View();
        }
        public IActionResult SASupervisorList()
        {
            return View();
        }
    }
}
