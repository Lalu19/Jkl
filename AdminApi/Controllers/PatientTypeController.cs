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
    public class PatientTypeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<PatientType> _patientTypeRepo;
        public PatientTypeController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<PatientType> patientTypeRepo
                               )
        {
            _config = config;
            _context = context;
            _patientTypeRepo = patientTypeRepo;

        }
        [HttpPost]
        public IActionResult PatientTypeCreate(PatientTypeDTO patientTypeDTO)
        {
            var objCheck = _context.PatientType.SingleOrDefault(opt => opt.TypeOfPatient == patientTypeDTO.TypeOfPatient && opt.IsDeleted == false);
            try
            {
                if (objCheck == null)
                {
                    PatientType patient= new PatientType();
                    patient.TypeOfPatient = patientTypeDTO.TypeOfPatient;
                    patient.CreatedBy = patientTypeDTO.CreatedBy;
                    var obj = _patientTypeRepo.Insert(patient);
                    return Ok(obj);

                }
                else if (objCheck != null)
                {
                    return Accepted(new Confirmation { Status = "duplicate", ResponseMsg = "Duplicate PatientType!" });
                }
                return Accepted(new Confirmation { Status = "error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetPatientTypeList()
        {
            try
            {
                var list = (from u in _context.PatientType
                            select new
                            {
                                u.PatientTypeId,
                                u.TypeOfPatient,
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

        [HttpGet("{patienttypeid}")]
        public ActionResult GetSinglePatientTypeId(int patienttypeid)
        {
            try
            {
                var singlepatient= _patientTypeRepo.SelectById(patienttypeid);

                return Ok(singlepatient);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdatePatientType(PatientTypeUpdateDTO patientTypeUpdateDTO)
        {
            try
            {
                var patientType = _context.PatientType.SingleOrDefault(opt => opt.PatientTypeId == patientTypeUpdateDTO.PatientTypeId);
                patientType.TypeOfPatient = patientTypeUpdateDTO.TypeOfPatient;
                patientType.UpdatedBy = patientTypeUpdateDTO.UpdatedBy;
                patientType.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(patientType);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{patienttypeid}/{DeletedBy}")]
        public ActionResult DeletePatientType(int patienttypeid, int DeletedBy)
        {
            try
            {
                var patientType = _context.PatientType.SingleOrDefault(opt => opt.PatientTypeId == patienttypeid);
                patientType.IsDeleted = true;
                patientType.UpdatedBy = DeletedBy;
                patientType.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(patientType);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
    }
}
