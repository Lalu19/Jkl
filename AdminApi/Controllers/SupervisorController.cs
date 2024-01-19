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
    public class SupervisorController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Supervisor> _Supervisor;
        public SupervisorController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Supervisor> Supervisor
                               )
        {
            _config = config;
            _context = context;
            _Supervisor = Supervisor;

        }
        [HttpPost]
        public IActionResult SupervisorCreate(SupervisorDTO supervisorDTO)
        {
            try
            {
                Supervisor supervisor = new Supervisor();
                supervisor.SupervisorName = supervisorDTO.SupervisorName;
                supervisor.MobileNo = supervisorDTO.MobileNo;
                supervisor.Email = supervisorDTO.Email;
                supervisor.EmployeeId = supervisorDTO.EmployeeId;
                supervisor.Password = supervisorDTO.Password;
                supervisor.RePassword = supervisorDTO.RePassword;
                supervisor.HospitalMasterid = supervisorDTO.HospitalMasterid;
                supervisor.CreatedBy = supervisorDTO.CreatedBy;
                var obj = _Supervisor.Insert(supervisor);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetSupervisorList()
        {
            try
            {
                var list = (from u in _context.Supervisor
                            join k in _context.HospitalMasters on
                           u.HospitalMasterid equals k.HospitalMasterid
                            select new
                            {
                                u.SupervisorId,
                                u.SupervisorName,
                                u.MobileNo,
                                u.Email,
                                u.EmployeeId,
                                u.Password,
                                u.RePassword,
                                k.HospitalMasterid,
                                k.HospitalLogo,
                                k.HospitalName,
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
        [HttpGet("{hospitalid}")]
        public ActionResult HospitalWiseSupervisorList(int hospitalid)
        {
            try
            {
                var list = (from u in _context.Supervisor
                            join k in _context.HospitalMasters on
                           u.HospitalMasterid equals k.HospitalMasterid
                            select new
                            {
                                u.SupervisorId,
                                u.SupervisorName,
                                u.MobileNo,
                                u.Email,
                                u.EmployeeId,
                                u.Password,
                                u.RePassword,
                                k.HospitalMasterid,
                                k.HospitalLogo,
                                k.HospitalName,
                                u.IsDeleted
                            }).Where(x => x.HospitalMasterid==hospitalid && x.IsDeleted == false );
                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Supervisorid}")]
        public ActionResult GetSingleSupervisorId(int Supervisorid)
        {
            try
            {
                var Supervisor = _Supervisor.SelectById(Supervisorid);
                return Ok(Supervisor);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpPost]
        public ActionResult UpdateSupervisor(SupervisorUpdateDTO supervisorUpdateDTO)
        {
            try
            {
                var Supervisor = _context.Supervisor.SingleOrDefault(opt => opt.SupervisorId == supervisorUpdateDTO.SupervisorId);
                Supervisor.SupervisorName = supervisorUpdateDTO.SupervisorName;
                Supervisor.MobileNo = supervisorUpdateDTO.MobileNo;
                Supervisor.Email = supervisorUpdateDTO.Email;
                Supervisor.EmployeeId = supervisorUpdateDTO.EmployeeId;
                Supervisor.Password = supervisorUpdateDTO.Password;
                Supervisor.RePassword = supervisorUpdateDTO.RePassword;
                Supervisor.HospitalMasterid = supervisorUpdateDTO.HospitalMasterid;
                Supervisor.UpdatedBy = supervisorUpdateDTO.UpdatedBy;
                Supervisor.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(Supervisor);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{SupervisorId}/{DeletedBy}")]
        public ActionResult DeleteSupervisor(int SupervisorId, int DeletedBy)
        {
            try
            {
                var Supervisor = _context.Supervisor.SingleOrDefault(opt => opt.SupervisorId == SupervisorId);
                Supervisor.IsDeleted = true;
                Supervisor.UpdatedBy = DeletedBy;
                Supervisor.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(Supervisor);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{EMPid}/{password}")]
        public ActionResult Supervisorlogin(string EMPid, string password)
        {
            try
            {
                var list = (from u in _context.Supervisor
                            join k in _context.HospitalMasters on
                           u.HospitalMasterid equals k.HospitalMasterid
                            select new
                            {
                                u.SupervisorId,
                                u.SupervisorName,
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
