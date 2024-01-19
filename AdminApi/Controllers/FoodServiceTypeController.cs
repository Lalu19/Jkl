using Microsoft.AspNetCore.Mvc;
using AdminApi;
using AdminApi.Models;
using AdminApi.Models.App;
using AdminApi.DTO;
using AdminApi.DTO.App;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FoodServiceTypeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<FoodServiceType> _FoodServiceType;
        public FoodServiceTypeController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<FoodServiceType> FoodServiceType
                               )
        {
            _config = config;
            _context = context;
            _FoodServiceType = FoodServiceType;

        }
        [HttpPost]
        public IActionResult FoodServiceTypeCreate(FoodServiceTypeDTO foodServiceTypeDTO)
        {
            var objCheck = _context.FoodServiceType.SingleOrDefault(opt => opt.FoodServiceTypeName == foodServiceTypeDTO.FoodServiceTypeName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {
                    FoodServiceType FoodService = new FoodServiceType();
                    FoodService.FoodServiceTypeName = foodServiceTypeDTO.FoodServiceTypeName;
                    FoodService.CreatedBy = foodServiceTypeDTO.CreatedBy;
                    var obj = _FoodServiceType.Insert(FoodService);
                    return Ok(obj);

                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Food Service Type!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetFoodServiceTypeList()
        {
            try
            {
                var list = (from u in _context.FoodServiceType
                            select new
                            {
                                u.FoodServiceTypeId,
                                u.FoodServiceTypeName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false);
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{foodservicetypeid}")]
        public ActionResult GetSingleFoodServiceTypeId(int foodservicetypeid)
        {
            try
            {
                var singlefoodservicetype = _FoodServiceType.SelectById(foodservicetypeid);

                return Ok(singlefoodservicetype);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdateFoodServiceType(FoodServiceTypeUpdateDTO foodServiceTypeUpdateDTO)
        {
            try
            {
                var foodservicetype = _context.FoodServiceType.SingleOrDefault(opt => opt.FoodServiceTypeId == foodServiceTypeUpdateDTO.FoodServiceTypeId);
                foodservicetype.FoodServiceTypeName = foodServiceTypeUpdateDTO.FoodServiceTypeName;
                foodservicetype.UpdatedBy = foodServiceTypeUpdateDTO.UpdatedBy;
                foodservicetype.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(foodservicetype);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{foodservicetypeid}/{DeletedBy}")]
        public ActionResult DeleteFoodServiceType(int foodservicetypeid, int DeletedBy)
        {
            try
            {
                var foodservicetype = _context.FoodServiceType.SingleOrDefault(opt => opt.FoodServiceTypeId == foodservicetypeid);
                foodservicetype.IsDeleted = true;
                foodservicetype.UpdatedBy = DeletedBy;
                foodservicetype.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(foodservicetype);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
