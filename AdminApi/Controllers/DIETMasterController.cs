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
using QRCoder;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks.Dataflow;
using AdminApi.Data;

namespace AdminApi.Controllers
{
    [ApiController] 
    [Route("api/[controller]/[action]")]
    public class DIETMasterController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<DIETMaster> _DIETRepo;
        public DIETMasterController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<DIETMaster> DIETRepo
                               )
        {
            _config = config;
            _context = context;
            _DIETRepo = DIETRepo;
        }
        [HttpPost]
        public IActionResult CreateDiet(DIETMaster dietDTO)
        {
            try
            {
                DIETMaster DIET = new DIETMaster();
                DIET.PatientName = dietDTO.PatientName;
                DIET.HospitalMasterid = dietDTO.HospitalMasterid;
                DIET.FloorsName = dietDTO.FloorsName;
                DIET.BedId = dietDTO.BedId;
                DIET.PatientTypeId = dietDTO.PatientTypeId;
                DIET.DietTypeId = dietDTO.DietTypeId;
                DIET.FoodServiceTypeId = dietDTO.FoodServiceTypeId;
                DIET.SpecialInstruction = dietDTO.SpecialInstruction;
                DIET.status = "BarCode generate";
                DIET.Feedback = "Feedback not added";
                DIET.PatientStatus = dietDTO.PatientStatus;
                DIET.IP = dietDTO.IP;
                DIET.DietDate = System.DateTime.Now.Date;
                DIET.CreatedBy = dietDTO.CreatedBy;
                var obj = _DIETRepo.Insert(DIET);

                var bed = _context.BedMasters.SingleOrDefault(opt => opt.BedMasterId == DIET.BedId);

                bed.status = "Not-Available";
                bed.UpdatedBy = dietDTO.CreatedBy;
                bed.UpdatedOn = System.DateTime.Now;
                bed.OcupiedId = obj.DIETMasterId;
                _context.SaveChanges();

                return Ok(obj);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        [HttpPost]
        public IActionResult DietCreateByDietician(DIETMaster dietDTO)
        {
            try
            {
                DIETMaster DIET = new DIETMaster();
                DIET.PatientName = dietDTO.PatientName;
                DIET.HospitalMasterid = dietDTO.HospitalMasterid;
                DIET.FloorsName = dietDTO.FloorsName;
                DIET.BedId = dietDTO.BedId;
                DIET.PatientTypeId = dietDTO.PatientTypeId;
                DIET.DietTypeId = dietDTO.DietTypeId;
                DIET.FoodServiceTypeId = dietDTO.FoodServiceTypeId;
                DIET.SpecialInstruction = dietDTO.SpecialInstruction;
                DIET.status = "BarCode generate";
                DIET.Feedback = "Feedback not added";
                DIET.PatientStatus = dietDTO.PatientStatus;
                DIET.IP = dietDTO.IP;
                DIET.DietDate = System.DateTime.Now.Date;
                DIET.CreatedBy = dietDTO.CreatedBy;
                var obj = _DIETRepo.Insert(DIET);

                var bed = _context.BedMasters.SingleOrDefault(opt => opt.BedMasterId == DIET.BedId);

                bed.status = "Not-Available";
                bed.UpdatedBy = dietDTO.CreatedBy;
                bed.UpdatedOn = System.DateTime.Now;
                bed.OcupiedId = obj.DIETMasterId;
                _context.SaveChanges();

                return Ok(obj);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        [HttpPost]
        public IActionResult AdvanceDietCreateByDietician(DIETMaster dietDTO)
        {
            try
            {
                DIETMaster DIET = new DIETMaster();
                DIET.PatientName = dietDTO.PatientName;
                DIET.HospitalMasterid = dietDTO.HospitalMasterid;
                DIET.FloorsName = dietDTO.FloorsName;
                DIET.BedId = dietDTO.BedId;
                DIET.PatientTypeId = dietDTO.PatientTypeId;
                DIET.DietTypeId = dietDTO.DietTypeId;
                DIET.FoodServiceTypeId = dietDTO.FoodServiceTypeId;
                DIET.SpecialInstruction = dietDTO.SpecialInstruction;
                DIET.status = "BarCode generate";
                DIET.Feedback = "Feedback not added";
                DIET.PatientStatus = dietDTO.PatientStatus;
                DIET.IP = dietDTO.IP;
                DIET.DietDate = dietDTO.DietDate;
                DIET.CreatedBy = dietDTO.CreatedBy;
                var obj = _DIETRepo.Insert(DIET);

                var bed = _context.BedMasters.SingleOrDefault(opt => opt.BedMasterId == DIET.BedId);

                bed.status = "Not-Available";
                bed.UpdatedBy = dietDTO.CreatedBy;
                bed.UpdatedOn = System.DateTime.Now;
                bed.OcupiedId = obj.DIETMasterId;
                _context.SaveChanges();

                return Ok(obj);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }
        [HttpPost]
        public IActionResult FoodPlateRecive(FoodScanDTO dietDTO)
        {
            try
            {
                var DT = _context.DIETMasters.SingleOrDefault(opt => opt.DIETMasterId == dietDTO.DIETMasterId);
                DT.status = "Out From Kitchen";
                DT.PlateReciveDate = System.DateTime.Now;
                DT.FoodProviderLoginId = dietDTO.FoodProviderLoginId;
                _context.SaveChanges();
                return Ok(DT);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult FoodPlateDeiver(FoodScanDTO dietDTO)
        {
            try
            {
                var DT = _context.DIETMasters.SingleOrDefault(opt => opt.DIETMasterId == dietDTO.DIETMasterId);
                DT.status = "Deliver to Patient";
                DT.PlateDeliverDate = System.DateTime.Now;
                DT.FoodProviderLoginId = dietDTO.FoodProviderLoginId;
                _context.SaveChanges();
                return Ok(DT);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult FoodPlateCollection(FoodScanDTO dietDTO)
        {
            try
            {
                var DT = _context.DIETMasters.SingleOrDefault(opt => opt.DIETMasterId == dietDTO.DIETMasterId);
                DT.status = "Clearance";
                DT.PlateCollectionDate = System.DateTime.Now;
                DT.FoodProviderLoginId = dietDTO.FoodProviderLoginId;
                _context.SaveChanges();
                return Ok(DT);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult FoodPending(FoodScanDTO dietDTO)
        {
            try
            {
                var DT = _context.DIETMasters.SingleOrDefault(opt => opt.DIETMasterId == dietDTO.DIETMasterId);
                DT.status = "Pending";
                DT.PlateCollectionDate = System.DateTime.Now;
                DT.FoodProviderLoginId = dietDTO.FoodProviderLoginId;
                _context.SaveChanges();
                return Ok(DT);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult BrilliantFeedback(FeedbackDTO feedbackDTO)
        {
            try
            {
                var FD = _context.DIETMasters.SingleOrDefault(opt => opt.DIETMasterId == feedbackDTO.DIETMasterId);
                FD.Feedback = "Brilliant";
                _context.SaveChanges();
                return Ok(FD);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult GoodFeedback(FeedbackDTO feedbackDTO)
        {
            try
            {
                var FD = _context.DIETMasters.SingleOrDefault(opt => opt.DIETMasterId == feedbackDTO.DIETMasterId);
                FD.Feedback = "Good";
                _context.SaveChanges();
                return Ok(FD);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult OkFeedback(FeedbackDTO feedbackDTO)
        {
            try
            {
                var FD = _context.DIETMasters.SingleOrDefault(opt => opt.DIETMasterId == feedbackDTO.DIETMasterId);
                FD.Feedback = "Ok";
                _context.SaveChanges();
                return Ok(FD);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult NotGoodFeedback(FeedbackDTO feedbackDTO)
        {
            try
            {
                var FD = _context.DIETMasters.SingleOrDefault(opt => opt.DIETMasterId == feedbackDTO.DIETMasterId);
                FD.Feedback = "Not Good";
                _context.SaveChanges();
                return Ok(FD);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetDietList()
        {
            try
            {
                var list = (from u in _context.DIETMasters
                            join k in _context.BedMasters on
                            u.BedId equals k.BedMasterId
                            join i in _context.FoodServiceType on
                            u.FoodServiceTypeId equals i.FoodServiceTypeId
                            join j in _context.DietType on
                            u.DietTypeId equals j.DietTypeId
                            select new
                            {
                                u.DIETMasterId,
                                u.PatientName,
                                u.SpecialInstruction,
                                u.BedId,
                                k.BedNo,
                                u.FloorsName,
                                u.FoodServiceTypeId,
                                i.FoodServiceTypeName,
                                u.status,
                                u.Feedback,
                                u.PlateReciveDate,
                                u.PlateDeliverDate,
                                u.PlateCollectionDate,
                                u.IP,
                                u.PatientStatus,
                                j.DietTypeName,
                                u.IsDeleted,
                                u.CreatedOn,
                   
                            }).Where(x => x.IsDeleted == false && x.status != "Clearance");
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{hospitalid}")]
        public ActionResult GetHospitalwiseDietList(int hospitalid)
        {
            try
            {
                var list = (from u in _context.DIETMasters
                            join k in _context.BedMasters on
                            u.BedId equals k.BedMasterId
                            join i in _context.FoodServiceType on
                            u.FoodServiceTypeId equals i.FoodServiceTypeId
                            join j in _context.DietType on
                            u.DietTypeId equals j.DietTypeId
                            join a in _context.HospitalMasters on
                            u.HospitalMasterid equals a.HospitalMasterid
                            select new
                            {
                                u.DIETMasterId,
                                u.PatientName,
                                u.SpecialInstruction,
                                u.BedId,
                                u.HospitalMasterid,
                                a.HospitalName,
                                k.BedNo,
                                u.FloorsName,
                                u.FoodServiceTypeId,
                                i.FoodServiceTypeName,
                                u.status,
                                u.Feedback,
                                u.PlateReciveDate,
                                u.PlateDeliverDate,
                                u.PlateCollectionDate,
                                j.DietTypeName,
                                u.IP,
                                u.PatientStatus,
                                u.IsDeleted,
                                u.CreatedOn,
                            }).Where(x => x.IsDeleted == false && x.HospitalMasterid == hospitalid && x.status != "Clearance");
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{hospitalid}")]
        public ActionResult GetHospitalwiseDietHistory(int hospitalid)
        {
            try
            {
                var list = (from u in _context.DIETMasters
                            join k in _context.BedMasters on
                            u.BedId equals k.BedMasterId
                            join i in _context.FoodServiceType on
                            u.FoodServiceTypeId equals i.FoodServiceTypeId
                            join j in _context.DietType on
                            u.DietTypeId equals j.DietTypeId
                            join a in _context.HospitalMasters on
                            u.HospitalMasterid equals a.HospitalMasterid
                            select new
                            {
                                u.DIETMasterId,
                                u.PatientName,
                                u.SpecialInstruction,
                                u.BedId,
                                u.HospitalMasterid,
                                a.HospitalName,
                                k.BedNo,
                                u.FloorsName,
                                u.FoodServiceTypeId,
                                i.FoodServiceTypeName,
                                u.status,
                                u.Feedback,
                                u.PlateReciveDate,
                                u.PlateDeliverDate,
                                u.PlateCollectionDate,
                                j.DietTypeName,
                                u.IP,
                                u.PatientStatus,
                                u.IsDeleted,
                                u.CreatedOn,
                                u.DietDate,
                            }).Where(x => x.IsDeleted == false && x.HospitalMasterid == hospitalid);
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet]
        public ActionResult GetBednoinDietList()
        {
            try
            {
                var list = (from u in _context.DIETMasters
                            join k in _context.BedMasters on
                            u.BedId equals k.BedMasterId
                            join i in _context.FoodServiceType on
                            u.FoodServiceTypeId equals i.FoodServiceTypeId
                            select new
                            {
                                u.DIETMasterId,
                                u.PatientName,
                                u.SpecialInstruction,
                                u.BedId,
                                k.BedNo,
                                u.FloorsName,
                                u.FoodServiceTypeId,
                                i.FoodServiceTypeName,
                                u.status,
                                u.Feedback,
                                u.FoodProviderLoginId,
                                u.SupervisorId,
                                u.PlateReciveDate,
                                u.PlateDeliverDate,
                                u.PlateCollectionDate,
                                u.IsDeleted,
                                u.CreatedOn,

                            }).Where(x => x.IsDeleted == false && x.SupervisorId==null && x.FoodProviderLoginId==null);
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{hospitalid}/{dietdate}/{servicetypeid}")]
        public ActionResult GetBednoinDietListbyhospitalid(int hospitalid,DateTime dietdate,int servicetypeid)
        {
            try
            {
                var list = (from u in _context.DIETMasters
                            join k in _context.BedMasters on
                            u.BedId equals k.BedMasterId
                            join i in _context.FoodServiceType on
                            u.FoodServiceTypeId equals i.FoodServiceTypeId
                            select new
                            {
                                u.DIETMasterId,
                                u.PatientName,
                                u.SpecialInstruction,
                                u.BedId,
                                k.BedNo,
                                u.FloorsName,
                                u.FoodServiceTypeId,
                                i.FoodServiceTypeName,
                                u.status,
                                u.Feedback,
                                u.FoodProviderLoginId,
                                u.SupervisorId,
                                u.HospitalMasterid,
                                u.PlateReciveDate,
                                u.PlateDeliverDate,
                                u.PlateCollectionDate,
                                u.IsDeleted,
                                u.CreatedOn,
                                u.DietDate,

                            }).Where(x => x.IsDeleted == false && x.SupervisorId == null && x.FoodProviderLoginId == null && x.HospitalMasterid==hospitalid && x.DietDate==dietdate && x.FoodServiceTypeId== servicetypeid);
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{hospitalid}/{foodproviderid}")]
        public ActionResult GetHospitalwiseBarCodeList(int hospitalid, int foodproviderid)
        {
            try
            {
                var list = (from u in _context.DIETMasters
                            join k in _context.BedMasters on
                            u.BedId equals k.BedMasterId
                            join i in _context.FoodServiceType on
                            u.FoodServiceTypeId equals i.FoodServiceTypeId
                            join j in _context.DietType on
                            u.DietTypeId equals j.DietTypeId
                            join a in _context.HospitalMasters on
                            u.HospitalMasterid equals a.HospitalMasterid
                            select new
                            {
                                u.DIETMasterId,
                                u.PatientName,
                                u.SpecialInstruction,
                                u.BedId,
                                u.HospitalMasterid,
                                a.HospitalName,
                                k.BedNo,
                                u.FloorsName,
                                u.FoodServiceTypeId,
                                i.FoodServiceTypeName,
                                u.status,
                                u.Feedback,
                                u.PlateReciveDate,
                                u.PlateDeliverDate,
                                u.PlateCollectionDate,
                                j.DietTypeName,
                                u.IP,
                                u.IsDeleted,
                                u.CreatedOn,
                                u.FoodProviderLoginId


                            }).Where(x => x.IsDeleted == false && x.HospitalMasterid == hospitalid && x.FoodProviderLoginId == foodproviderid && x.status != "Clearance");
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet]
        public ActionResult GetQrcodeList()
        {
            try
            {
                var list = (from u in _context.DIETMasters
                            join k in _context.BedMasters on
                            u.BedId equals k.BedMasterId
                            join i in _context.FoodServiceType on
                            u.FoodServiceTypeId equals i.FoodServiceTypeId
                            join j in _context.DietType on
                            u.DietTypeId equals j.DietTypeId
                            join a in _context.HospitalMasters on
                            u.HospitalMasterid equals a.HospitalMasterid
                            select new
                            {
                                u.DIETMasterId,
                                u.PatientName,
                                u.SpecialInstruction,
                                u.BedId,
                                u.HospitalMasterid,
                                a.HospitalName,
                                k.BedNo,
                                u.FloorsName,
                                u.FoodServiceTypeId,
                                i.FoodServiceTypeName,
                                u.status,
                                u.Feedback,
                                u.PlateReciveDate,
                                u.PlateDeliverDate,
                                u.PlateCollectionDate,
                                j.DietTypeName,
                                u.IP,
                                u.IsDeleted,
                                u.CreatedOn,

                            }).Where(x => x.IsDeleted == false && x.status != "Clearance");
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{foodproviderid}")]
        public ActionResult GetFoodproviderwiseDietList(int foodproviderid)
        {
            try
            {
                var list = (from u in _context.DIETMasters
                            join k in _context.BedMasters on
                            u.BedId equals k.BedMasterId
                            join i in _context.DietType on
                            u.DietTypeId equals i.DietTypeId
                            join j in _context.FoodServiceType on 
                            u.FoodServiceTypeId equals j.FoodServiceTypeId
                            select new
                            {
                                u.DIETMasterId,
                                u.PatientName,
                                u.SpecialInstruction,
                                u.BedId,
                                k.BedNo,
                                u.FloorsName,
                                u.status,
                                u.DietTypeId,
                                i.DietTypeName,
                                u.FoodServiceTypeId,
                                j.FoodServiceTypeName,
                                u.IsDeleted,
                                u.CreatedOn,
                                u.CreatedBy,
                                u.FoodProviderLoginId,
                                
                            }).Where(x => x.IsDeleted == false && x.FoodProviderLoginId == foodproviderid && x.status != "Clearance");
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{dietid}")]
        public ActionResult GetSingleDietId(int dietid)
        {
            try
            {
                var singleDIET = _DIETRepo.SelectById(dietid);

                return Ok(singleDIET);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdateDiet(DietUpdateDTO DIETUpdateDTO)
        {
            try
            {
                var DIET = _context.DIETMasters.SingleOrDefault(opt => opt.DIETMasterId == DIETUpdateDTO.DIETMasterId);
                DIET.PatientName = DIETUpdateDTO.PatientName;
                DIET.HospitalMasterid = DIETUpdateDTO.HospitalMasterid;
                DIET.FloorsName = DIETUpdateDTO.FloorsName;
                DIET.BedId = DIETUpdateDTO.BedId;
                DIET.PatientTypeId = DIETUpdateDTO.PatientTypeId;
                DIET.FoodServiceTypeId = DIETUpdateDTO.FoodServiceTypeId;
                DIET.DietTypeId = DIETUpdateDTO.DietTypeId;
                DIET.SpecialInstruction = DIETUpdateDTO.SpecialInstruction;
                DIET.IP = DIETUpdateDTO.IP;
                DIET.PatientStatus = DIETUpdateDTO.PatientStatus;
                DIET.UpdatedBy = DIETUpdateDTO.UpdatedBy;
                DIET.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(DIET);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult AssigneeFoodProvider(AssigneeFoodProviderDTO FPUpdateDTO)
        {
            try
            {

                for (int i = 0; i < FPUpdateDTO.dietMasterId.Count; i++)
                {
                    var FP = _context.DIETMasters.SingleOrDefault(opt => opt.DIETMasterId == int.Parse( FPUpdateDTO.dietMasterId[i]));
                    FP.FoodProviderLoginId = FPUpdateDTO.FoodProviderLoginId;
                    FP.SupervisorId = FPUpdateDTO.SupervisorId;
                    _context.SaveChanges();
                    
                }
                return Ok(FPUpdateDTO);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{DIETid}/{DeletedBy}")]
        public ActionResult DeleteDiet(int DIETid, int DeletedBy)
        {
            try
            {
                var DIET = _context.DIETMasters.SingleOrDefault(opt => opt.DIETMasterId == DIETid);
                DIET.IsDeleted = true;
                DIET.DeletedBy = DeletedBy;
                DIET.DeletedOn = System.DateTime.Now;
                _context.SaveChanges();

                var bed = _context.BedMasters.SingleOrDefault(opt => opt.BedMasterId == DIET.BedId);
                bed.status = "Available";
                _context.SaveChanges();

                return Ok(DIET);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{DIETid}")]
        public ActionResult PlanDischarge(int DIETid)
        {
            try
            {
                var DIET = _context.DIETMasters.SingleOrDefault(opt => opt.DIETMasterId == DIETid);
                DIET.PatientStatus = "Plan Discharge";
                _context.SaveChanges();
                return Ok(DIET);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Dietid}")]
        public ActionResult GetDietDetails(int Dietid)
        {
            try
            {
                var list = (from u in _context.DIETMasters
                            join k in _context.BedMasters on
                            u.BedId equals k.BedMasterId
                            join l in _context.FoodServiceType on
                            u.FoodServiceTypeId equals l.FoodServiceTypeId
                            join i in _context.DietType on
                            u.DietTypeId equals i.DietTypeId
                            select new { u.DIETMasterId,
                                u.PatientName, 
                                u.SpecialInstruction,
                                u.BedId, k.BedNo, 
                                u.IsDeleted, 
                                u.CreatedOn, 
                                u.status,
                                u.FoodServiceTypeId,
                                l.FoodServiceTypeName,
                                u.DietTypeId,
                                i.DietTypeName,
                                u.PlateReciveDate,
                                u.PlateDeliverDate,
                                u.PlateCollectionDate
                            }).Where(x => x.IsDeleted == false && x.DIETMasterId == Dietid);

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

        [HttpGet("{hospitalid}")]
        public ActionResult GetDietReport(int hospitalid)
        {
            try
            {
                var list = (from u in _context.DIETMasters
                            join k in _context.BedMasters on
                            u.BedId equals k.BedMasterId
                            join a in _context.HospitalMasters on
                            u.HospitalMasterid equals a.HospitalMasterid
                            join s in _context.FoodProviderLogins on 
                            u.FoodProviderLoginId equals s.FoodProviderLoginId
                            join p in _context.DietType on 
                            u.DietTypeId equals p.DietTypeId
                            join j in _context.FoodServiceType on
                            u.FoodServiceTypeId equals j.FoodServiceTypeId
                            select new
                            {
                                u.DIETMasterId,
                                u.PatientName,
                                u.SpecialInstruction,
                                u.BedId,
                                k.BedNo,
                                u.Feedback,
                                u.status,
                                u.PlateReciveDate,
                                u.PlateDeliverDate,
                                u.PlateCollectionDate,
                                u.DietTypeId,
                                p.DietTypeName,
                                u.IsDeleted,
                                u.FoodServiceTypeId,
                                j.FoodServiceTypeName,
                                a.HospitalMasterid,
                                u.CreatedOn,
                                a.HospitalName,
                                s.FoodProviderLoginId,
                                s.FoodProviderName,
                                a.Address1,
                                u.IP,
                                Tat1 = String.Format("{0}:{1}:{2}", u.PlateDeliverDate.Value.Subtract(u.PlateReciveDate.Value).Hours, u.PlateDeliverDate.Value.Subtract(u.PlateReciveDate.Value).Minutes, u.PlateDeliverDate.Value.Subtract(u.PlateReciveDate.Value).Seconds),
                                Tat2 = String.Format("{0}:{1}:{2}", u.PlateCollectionDate.Value.Subtract(u.PlateDeliverDate.Value).Hours, u.PlateCollectionDate.Value.Subtract(u.PlateDeliverDate.Value).Minutes, u.PlateCollectionDate.Value.Subtract(u.PlateDeliverDate.Value).Seconds),

                            }).Where(x => x.HospitalMasterid == hospitalid );
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{FoodServiceTypeId}/{hospitalid}")]
        public ActionResult GetFoodProviderNameByServicetypeid(int FoodServiceTypeId , int hospitalid)
        {
            try
            {

                var list = (from u in _context.DIETMasters
                            join i in _context.FoodProviderLogins on
                            u.FoodProviderLoginId equals i.FoodProviderLoginId
                            select new
                            {
                               u.IsDeleted,
                               u.HospitalMasterid,
                               u.FoodProviderLoginId,
                               i.FoodProviderName,
                               i.MobileNo,
                               u.FoodServiceTypeId,
                            }).Where(x => x.IsDeleted == false && x.FoodServiceTypeId == FoodServiceTypeId && x.HospitalMasterid == hospitalid ).Distinct();
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{FoodProviderLoginId}/{hospitalid}")]
        public ActionResult GetBedNoByFoodproviderid(int FoodProviderLoginId , int hospitalid)
        {
            try
            {
                var list = (from u in _context.DIETMasters
                            join l in _context.BedMasters on
                            u.BedId equals l.BedMasterId
                            select new
                            {
                                u.DIETMasterId,
                                u.IsDeleted,
                                u.HospitalMasterid,
                                u.FoodProviderLoginId,
                                u.BedId,
                                l.BedNo,
                                u.status
                            }).Where(x => x.IsDeleted == false && x.FoodProviderLoginId == FoodProviderLoginId && x.HospitalMasterid == hospitalid);
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{bedid}")]
        public ActionResult GetDietbyBedid(int bedid)
        {
            try
            {
                var list = (from u in _context.DIETMasters
                            select new
                            {
                                u.DIETMasterId,
                                u.PatientName,
                                u.IP,
                                u.BedId,
                                u.HospitalMasterid,
                                u.PatientTypeId,
                                u.DietTypeId,
                                u.FloorsName,
                                u.FoodServiceTypeId,
                                u.SpecialInstruction,
                                u.PatientStatus,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.BedId == bedid);
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
