using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class PatientTypeController : Controller
    {
        public IActionResult PatientTypeCreate()
        {
            return View();
        }
        public IActionResult PatientTypeList()
        {
            return View();
        }
        public IActionResult PatientTypeEdit(int patientTypeId)
        {
            ViewBag.patientTypeId = patientTypeId;
            return View();
        }
    }
}
