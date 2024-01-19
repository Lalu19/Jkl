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
    public class DieticianController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<DieticianMaster> _DieticianRepo;
        public DieticianController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<DieticianMaster> DieticianRepo
                               )
        {
            _config = config;
            _context = context;
            _DieticianRepo = DieticianRepo;

        }
       
        [HttpPost]
        public IActionResult CreateDietician(DieticianDTO dieticianDTO)
        {
            
            try
            {
               DieticianMaster dietician = new DieticianMaster();
               dietician.DieticianName = dieticianDTO.DieticianName;
               dietician.MobileNo = dieticianDTO.MobileNo;
               dietician.Email = dieticianDTO.Email;
               dietician.EmployeeId = dieticianDTO.EmployeeId;
               dietician.Password = dieticianDTO.Password;
               dietician.RePassword = dieticianDTO.RePassword;
               dietician.HospitalMasterid = dieticianDTO.HospitalMasterid;
               dietician.CreatedBy = dieticianDTO.CreatedBy;
               var obj = _DieticianRepo.Insert(dietician);
               return Ok(obj);
            }
            catch(Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
            
        }

        
        [HttpGet]
        public ActionResult GetDieticianList()
        {
            try
            {
                var list = (from u in _context.DieticianMasters
                            join k in _context.HospitalMasters on
                           u.HospitalMasterid equals k.HospitalMasterid
                            select new { u.DieticianMasterId,
                                u.DieticianName,
                                u.MobileNo,
                                u.Email,
                                u.EmployeeId,
                                u.Password,
                                u.RePassword,
                                k.HospitalMasterid,
                                k.HospitalName,
                                k.HospitalLogo,
                                u.IsDeleted }).Where(x => x.IsDeleted == false);
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{hospitalid}")]
        public ActionResult GetHospitalWiseDieticianList(int hospitalid)
        {
            try
            {
                var list = (from u in _context.DieticianMasters
                            join k in _context.HospitalMasters on
                           u.HospitalMasterid equals k.HospitalMasterid
                            select new
                            {
                                u.DieticianMasterId,
                                u.DieticianName,
                                u.MobileNo,
                                u.Email,
                                u.EmployeeId,
                                u.Password,
                                u.RePassword,
                                k.HospitalMasterid,
                                k.HospitalName,
                                k.HospitalLogo,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.HospitalMasterid==hospitalid );
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{dieticianid}")]
        public ActionResult GetSingleDieticianId(int dieticianid)
        {
            try
            {
                var singleDietician = _DieticianRepo.SelectById(dieticianid);
                return Ok(singleDietician);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        
        [HttpPost]
        public ActionResult Updatez(DieticianUpdateDTO dieticianUpdateDTO)
        {
            try
            {
                var Dietician = _context.DieticianMasters.SingleOrDefault(opt => opt.DieticianMasterId == dieticianUpdateDTO.DieticianMasterId);
                Dietician.DieticianName = dieticianUpdateDTO.DieticianName;
                Dietician.MobileNo = dieticianUpdateDTO.MobileNo;
                Dietician.Email = dieticianUpdateDTO.Email;
                Dietician.EmployeeId = dieticianUpdateDTO.EmployeeId;
                Dietician.Password = dieticianUpdateDTO.Password;
                Dietician.RePassword = dieticianUpdateDTO.RePassword;
                Dietician.HospitalMasterid = dieticianUpdateDTO.HospitalMasterid;
                Dietician.UpdatedBy = dieticianUpdateDTO.UpdatedBy;
                Dietician.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(Dietician);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{dieticianid}/{DeletedBy}")]
        public ActionResult DeleteDietician(int dieticianid, int DeletedBy)
        {
            try
            {
                var dietician  = _context.DieticianMasters.SingleOrDefault(opt => opt.DieticianMasterId == dieticianid);
                dietician.IsDeleted = true;
                dietician.UpdatedBy = DeletedBy;
                dietician.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(dietician);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

       
        [HttpGet("{EMPid}/{password}")]
        public ActionResult Dieticianlogin(string EMPid, string password)
        {

            try
            {
                var list = (from u in _context.DieticianMasters
                            join k in _context.HospitalMasters on
                           u.HospitalMasterid equals k.HospitalMasterid
                            select new
                            {
                                u.DieticianMasterId,
                                u.DieticianName,
                                u.MobileNo,
                                u.Email,
                                u.EmployeeId,
                                u.Password,
                                u.RePassword,
                                k.HospitalMasterid,
                                k.HospitalLogo,
                            }).Where(x => x.EmployeeId == EMPid && x.Password == password).FirstOrDefault();

                if (list != null)
                {
                    return Ok(list);
                }
                return NoContent();

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }
    }
}
