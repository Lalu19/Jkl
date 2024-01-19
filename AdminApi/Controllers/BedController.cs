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
    public class BedController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<BedMaster> _BedRepo;
        public BedController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<BedMaster> BedRepo
                               )
        {
            _config = config;
            _context = context;
            _BedRepo = BedRepo;

        }

        [HttpPost]
        public IActionResult CreateBed(BedMasterDTO bedMasterDTO)
        {
            try
            {
                for (int i = 0; i < bedMasterDTO.BedDTOs.Count; i++)
                {
                    BedMaster bed = new BedMaster();
                    bed.HospitalMasterid = bedMasterDTO.BedDTOs[i].HospitalMasterid;
                    bed.FloorNoid = bedMasterDTO.BedDTOs[i].FloorNoid;
                    bed.FloorsName = bedMasterDTO.BedDTOs[i].FloorsName;
                    bed.BedNo = bedMasterDTO.BedDTOs[i].BedNo;
                    bed.status = "Available";
                    bed.CreatedBy = bedMasterDTO.BedDTOs[i].CreatedBy;
                    _BedRepo.Insert(bed);

                }

                return Ok(bedMasterDTO);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetBedList()
        {
            try
            {
                var list = (from u in _context.BedMasters
                            join k in _context.HospitalMasters on
                            u.HospitalMasterid equals k.HospitalMasterid
                            select new { u.BedMasterId,
                                k.FloorNo,
                                u.BedNo,
                                u.status,
                                k.HospitalMasterid,
                                k.HospitalName,
                                u.FloorsName,
                                u.IsDeleted }).Where(x => x.IsDeleted == false );

                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{hospitalid}")]
        public ActionResult GetHospitalWiseBedList( int hospitalid)
        {
            try
            {
                var list = (from u in _context.BedMasters
                            join k in _context.HospitalMasters on
                            u.HospitalMasterid equals k.HospitalMasterid
                            select new
                            {
                                u.BedMasterId,
                                k.FloorNo,
                                u.BedNo,
                                u.status,
                                k.HospitalMasterid,
                                k.HospitalName,
                                u.FloorsName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.HospitalMasterid==hospitalid);

                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetAvailableBedList()
        {
            try
            {
                var list = (from u in _context.BedMasters

                            select new { u.BedMasterId, u.FloorNoid, u.BedNo, u.status, u.IsDeleted }).Where(x => x.IsDeleted == false && x.status == "Available");


                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{bedid}")]
        public ActionResult GetSingleHospitalId(int bedid)
        {
            try
            {
                var singlebed = _BedRepo.SelectById(bedid);

                return Ok(singlebed);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdateBed(BedMasterUpdateDTO bedUpdateDTO)
        {
            try
            {
                var bed = _context.BedMasters.SingleOrDefault(opt => opt.BedMasterId == bedUpdateDTO.BedMasterId);
                bed.FloorNoid = bedUpdateDTO.FloorNoid;
                bed.FloorsName = bedUpdateDTO.FloorsName;
                bed.BedNo = bedUpdateDTO.BedNo;
                bed.HospitalMasterid = bedUpdateDTO.HospitalMasterid;
                bed.UpdatedBy = bedUpdateDTO.UpdatedBy;
                bed.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(bed);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{bedid}/{DeletedBy}")]
        public ActionResult DeleteBed(int bedid, int DeletedBy)
        {
            try
            {
                var bed = _context.BedMasters.SingleOrDefault(opt => opt.BedMasterId == bedid);
                bed.IsDeleted = true;
                bed.UpdatedBy = DeletedBy;
                bed.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(bed);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{floorname}/{hospitalid}")]
        public ActionResult GetBedByFloorName(int hospitalid ,string floorname)
        {
            try
            {
                var list = (from u in _context.BedMasters
                            select new
                            {
                                u.BedMasterId,
                                u.BedNo,
                                u.IsDeleted,
                                u.FloorsName,
                                u.HospitalMasterid,
                                u.status,
                            }).Where(x => x.IsDeleted == false && x.FloorsName==floorname && x.HospitalMasterid==hospitalid && x.status== "Available");
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{floorname}/{hospitalid}")]
        public ActionResult GetBedByFloorNameInDietcian(int hospitalid, string floorname)
        {
            try
            {
                var list = (from u in _context.BedMasters
                            select new
                            {
                                u.BedMasterId,
                                u.BedNo,
                                u.IsDeleted,
                                u.FloorsName,
                                u.HospitalMasterid,
                                u.status,
                            }).Where(x => x.IsDeleted == false && x.FloorsName == floorname && x.HospitalMasterid == hospitalid);
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

    }
}
