using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminClient.Controllers
{
    public class HospitalController : Controller
    {
        public IActionResult HospitalCreate()
        {
            return View();
        }
        public IActionResult HospitalList()
        {
            return View();
        }
        public IActionResult HospitalEdit(int hospitalMasterid)
        {
            ViewBag.hospitalMasterid = hospitalMasterid;
            return View();
        }
    }
}
