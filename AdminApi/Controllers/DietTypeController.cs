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
    public class DietTypeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<DietType> _DietTypeRepo;
        public DietTypeController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<DietType> DietTypeRepo
                               )
        {
            _config = config;
            _context = context;
            _DietTypeRepo = DietTypeRepo;

        }
        [HttpPost]
        public IActionResult DietTypeCreate(DietTypeDTO dietTypeDTO)
        {
            var objCheck = _context.DietType.SingleOrDefault(opt => opt.DietTypeName == dietTypeDTO.DietTypeName && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {
                    DietType diettype = new DietType();
                    diettype.DietTypeName = dietTypeDTO.DietTypeName;
                    diettype.CreatedBy = dietTypeDTO.CreatedBy;
                    var obj = _DietTypeRepo.Insert(diettype);
                    return Ok(obj);

                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Diet Type!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetDietTypeList()
        {
            try
            {
                var list = (from u in _context.DietType
                            select new
                            {
                                u.DietTypeId,
                                u.DietTypeName,
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

        [HttpGet("{diettypeid}")]
        public ActionResult GetSingleDietTypeId(int diettypeid)
        {
            try
            {
                var singlediettype = _DietTypeRepo.SelectById(diettypeid);

                return Ok(singlediettype);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdateDietType(DietTypeUpdateDTO dietTypeUpdateDTO)
        {
            try
            {
                var diettype = _context.DietType.SingleOrDefault(opt => opt.DietTypeId == dietTypeUpdateDTO.DietTypeId);
                diettype.DietTypeName = dietTypeUpdateDTO.DietTypeName;
                diettype.UpdatedBy = dietTypeUpdateDTO.UpdatedBy;
                diettype.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(diettype);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{diettypeid}/{DeletedBy}")]
        public ActionResult DeleteDietType(int diettypeid, int DeletedBy)
        {
            try
            {
                var diettype = _context.DietType.SingleOrDefault(opt => opt.DietTypeId == diettypeid);
                diettype.IsDeleted = true;
                diettype.UpdatedBy = DeletedBy;
                diettype.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(diettype);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
