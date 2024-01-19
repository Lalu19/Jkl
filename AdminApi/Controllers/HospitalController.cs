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
    public class HospitalController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<HospitalMaster> _hospitalRepo;
        public HospitalController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<HospitalMaster> hospitalRepo
                               )
        {
            _config = config;
            _context = context;
            _hospitalRepo = hospitalRepo;

        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult CreateHospital(HospitalMasterDTO hospitalDTO)
        {
            var objCheck = _context.HospitalMasters.SingleOrDefault(opt => opt.HospitalName == hospitalDTO.HospitalName &&  opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {
                    HospitalMaster hospital = new HospitalMaster();
                    hospital.HospitalName = hospitalDTO.HospitalName;
                    hospital.Address1 = hospitalDTO.Address1;
                    hospital.Address2 = hospitalDTO.Address2;
                    hospital.ContactPerson = hospitalDTO.ContactPerson;
                    hospital.ContactPersonNo = hospitalDTO.ContactPersonNo;
                    hospital.MobileNo = hospitalDTO.MobileNo;
                    hospital.FloorNo = hospitalDTO.FloorNo;
                    hospital.HospitalLogo = hospitalDTO.HospitalLogo;
                    hospital.CreatedBy = hospitalDTO.CreatedBy;
                    var obj = _hospitalRepo.Insert(hospital);
                    return Ok(obj);

                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate Hospital!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetHospitalList()
        {
            try
            {
                var list = (from u in _context.HospitalMasters
                            select new { 
                                u.HospitalMasterid, 
                                u.HospitalName,
                                u.Address1,
                                u.Address2,
                                u.MobileNo,
                                u.ContactPerson,
                                u.ContactPersonNo,
                                u.FloorNo,
                                u.HospitalLogo,
                                u.IsDeleted }).Where(x => x.IsDeleted == false);
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        
        [Authorize(Roles = "Admin")]
        [HttpGet("{hospitalid}")]
        public ActionResult GetSingleHospitalId(int hospitalid)
        {
            try
            {
                var singlehospital = _hospitalRepo.SelectById(hospitalid);

                return Ok(singlehospital);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult UpdateHospital(HospitalMasterUpdateDTO hospitalmasterUpdateDTO)
        {
            try
            {
                var hospital = _context.HospitalMasters.SingleOrDefault(opt => opt.HospitalMasterid == hospitalmasterUpdateDTO.HospitalMasterid);
                hospital.HospitalName = hospitalmasterUpdateDTO.HospitalName;
                hospital.Address1 = hospitalmasterUpdateDTO.Address1;
                hospital.Address2 = hospitalmasterUpdateDTO.Address2;
                hospital.ContactPerson = hospitalmasterUpdateDTO.ContactPerson;
                hospital.ContactPersonNo = hospitalmasterUpdateDTO.ContactPersonNo;
                hospital.MobileNo = hospitalmasterUpdateDTO.MobileNo;
                hospital.FloorNo = hospitalmasterUpdateDTO.FloorNo;
                hospital.HospitalLogo = hospitalmasterUpdateDTO.HospitalLogo;
                hospital.UpdatedBy = hospitalmasterUpdateDTO.UpdatedBy;
                hospital.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(hospital);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("{hospitalid}/{DeletedBy}")]
        public ActionResult DeleteHospital(int hospitalid, int DeletedBy)
        {
            try
            {
                var hospital = _context.HospitalMasters.SingleOrDefault(opt => opt.HospitalMasterid == hospitalid);
                hospital.IsDeleted = true;
                hospital.UpdatedBy = DeletedBy;
                hospital.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(hospital);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{userid}")]
        public ActionResult GetHospitalByUserId(int userid)
        {
            try
            {
                var list = from u in _context.HospitalMasters
                           join r in _context.Users on
                           u.HospitalMasterid equals r.HospitalMasterid

                           select new
                           {   HospitalMasterid = u.HospitalMasterid,
                               HospitalName = u.HospitalName,
                               userid=r.UserId,
                               IsDeleted = u.IsDeleted,
                           } 
                           into x
                           where x.IsDeleted == false && x.userid == userid
                           select x;

                int totalRecords = list.Count();
                return Ok(new
                {
                    data = list,
                    recordsTotal = totalRecords,
                    recordsFiltered = totalRecords
                });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation
                {
                    Status = "error",
                    ResponseMsg = ex.Message
                });

            }
        }

        [HttpGet("{hospitalid}")]
        public ActionResult GetNoOfFloorByHospitalId(int hospitalid)
        {
            try
            {
                var list = from u in _context.HospitalMasters
                           select new
                           {

                               HospitalMasterid = u.HospitalMasterid,
                               Nooffloor = u.FloorNo,
                               IsDeleted = u.IsDeleted,


                           } into x
                           where x.IsDeleted == false && x.HospitalMasterid == hospitalid
                           select x;

                int totalRecords = list.Count();
                return Ok(new
                {
                    data = list,
                    recordsTotal = totalRecords,
                    recordsFiltered = totalRecords
                });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation
                {
                    Status = "error",
                    ResponseMsg = ex.Message
                });

            }
        }

    }
}
