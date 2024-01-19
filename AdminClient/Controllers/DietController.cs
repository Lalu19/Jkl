using AdminClient.ViewModels.App;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace AdminClient.Controllers
{
    public class DietController : Controller
    {
        private readonly string _apiBaseUrl;
        private readonly IConfiguration _configuration;
        public DietController(IConfiguration configuration)
        {

            _configuration = configuration;
            _apiBaseUrl = _configuration.GetValue<string>("WebAPIBaseUrl");
        }

        public IActionResult DietCreate()
        {
            return View();
        }
        public IActionResult DietList()
        {
            return View();
        }

        public IActionResult DietEdit(int dietMasterId)
        {
            ViewBag.dietMasterId = dietMasterId;
            return View();
        }

        public IActionResult SuperAdminDietEdit(int dietMasterId)
        {
            ViewBag.dietMasterId = dietMasterId;
            return View();
        }
        public IActionResult FPAssigneeCreate(int dietMasterId)
        {
            ViewBag.dietMasterId = dietMasterId;
            return View();
        }
        public IActionResult SAFPAssigneeCreate(int dietMasterId)
        {
            ViewBag.dietMasterId = dietMasterId;
            return View();
        }
        public IActionResult SuperAdminDietCreate()
        {
            return View();
        }
        public IActionResult SuperAdminDietList()
        {
            return View();
        }
        public IActionResult QrCodePrint()
        {
            return View();
        }
        public IActionResult DietHistory()
        {
            return View();
        }

        public async Task<JsonResult> GenerateQrCodeList()
        {

            string apiUrl = _apiBaseUrl + "/api/DIETMaster/GetQrcodeList";

            using (HttpClient client = new HttpClient())
            {

                var request = new HttpRequestMessage(HttpMethod.Get, apiUrl);
                using (var response = await client.SendAsync(request))
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();

                        var categoryList = JsonConvert.DeserializeObject<DietDataModel>(apiResponse);
                      
                        return Json( categoryList);

                    }
                }
            }
            return Json(null);

        }


    }
}
