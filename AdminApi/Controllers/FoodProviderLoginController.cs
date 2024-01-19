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
using System.Text;

namespace AdminApi.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FoodProviderLoginController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<FoodProviderLogin> _FoodProviderLoginRepo;
        public FoodProviderLoginController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<FoodProviderLogin> FoodProviderLoginRepo
                               )
        {
            _config = config;
            _context = context;
            _FoodProviderLoginRepo = FoodProviderLoginRepo;

        }
       
        [HttpPost]
        public IActionResult CreateFoodProviderLogin(FoodProviderLoginDTO foodproviderloginDTO)
        {
            try
            {
                FoodProviderLogin foodproviderlogin = new FoodProviderLogin();
                foodproviderlogin.FoodProviderName = foodproviderloginDTO.FoodProviderName;
                foodproviderlogin.HospitalMasterid = foodproviderloginDTO.HospitalMasterid;
                foodproviderlogin.MobileNo = foodproviderloginDTO.MobileNo;
                foodproviderlogin.EmpId = foodproviderloginDTO.EmpId;
                foodproviderlogin.Password = foodproviderloginDTO.Password;
                foodproviderlogin.RePassword = foodproviderloginDTO.RePassword;
                foodproviderlogin.CreatedBy = foodproviderloginDTO.CreatedBy;
                var obj = _FoodProviderLoginRepo.Insert(foodproviderlogin);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet]
        public ActionResult GetFoodProviderLoginList()
        {
            try
            {
                var list = (from u in _context.FoodProviderLogins
                            join k in _context.HospitalMasters on
                           u.HospitalMasterid equals k.HospitalMasterid
                            select new {
                                u.FoodProviderLoginId,
                                u.FoodProviderName,
                                u.MobileNo,
                                u.EmpId,
                                u.HospitalMasterid,
                                k.HospitalName,
                                u.Password,
                                u.RePassword,
                                u.IsDeleted}).Where(x => x.IsDeleted == false);

                int totalRecords = list.Count();
                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{hospitalid}")]
        public ActionResult GetFoodProviderHospitalwiseList(int hospitalid)
        {
            try
            {
                var list = (from u in _context.FoodProviderLogins
                            join k in _context.HospitalMasters on
                           u.HospitalMasterid equals k.HospitalMasterid
                            select new
                            {
                                u.FoodProviderLoginId,
                                u.FoodProviderName,
                                u.MobileNo,
                                u.EmpId,
                                u.HospitalMasterid,
                                k.HospitalName,
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


        //[FETCH BY ID]

        [HttpGet("{foodproviderloginid}")]
        public ActionResult GetSingleFoodProviderLoginId(int foodproviderloginid)
        {
            try
            {
                var singleFoodproviderlogin = _FoodProviderLoginRepo.SelectById(foodproviderloginid);

                return Ok(singleFoodproviderlogin);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        
        [HttpPost]
        public ActionResult UpdateFoodproviderlogin(FoodProviderLoginUpdateDTO foodroviderloginUpdateDTO)
        {
            try
            {
                var foodproviderlogin = _context.FoodProviderLogins.SingleOrDefault(opt => opt.FoodProviderLoginId == foodroviderloginUpdateDTO.FoodProviderLoginId);
                foodproviderlogin.FoodProviderName = foodroviderloginUpdateDTO.FoodProviderName;
                foodproviderlogin.FoodProviderLoginId = foodroviderloginUpdateDTO.FoodProviderLoginId;
                foodproviderlogin.MobileNo = foodroviderloginUpdateDTO.MobileNo;
                foodproviderlogin.EmpId = foodroviderloginUpdateDTO.EmpId;
                foodproviderlogin.Password = foodroviderloginUpdateDTO.Password;
                foodproviderlogin.RePassword = foodroviderloginUpdateDTO.RePassword;
                foodproviderlogin.UpdatedBy = foodroviderloginUpdateDTO.UpdatedBy;
                foodproviderlogin.UpdatedOn = System.DateTime.Now;


                _context.SaveChanges();
                return Ok(foodproviderlogin);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        //[DELETE]

        
        [HttpGet("{FoodProviderloginid}/{UpdatedBy}")]
        public ActionResult DeleteFoodProviderLogin(int FoodProviderloginid, int UpdatedBy)
        {
            try
            {
                var FoodProviderlogin = _context.FoodProviderLogins.SingleOrDefault(opt => opt.FoodProviderLoginId == FoodProviderloginid);
                FoodProviderlogin.IsDeleted = true;
                FoodProviderlogin.UpdatedBy = UpdatedBy;
                FoodProviderlogin.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(FoodProviderlogin);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [AllowAnonymous]
        [HttpGet("{EMPid}/{password}")]
        public ActionResult UserLoginfoodprovider(string EMPid, string password)
        {

            try
            {
                var list = (from u in _context.FoodProviderLogins
                            join k in _context.HospitalMasters on
                           u.HospitalMasterid equals k.HospitalMasterid
                            select new
                            {
                                u.FoodProviderLoginId,
                                u.FoodProviderName,
                                u.MobileNo,
                                u.EmpId,
                                u.Password,
                                u.RePassword,
                                k.HospitalMasterid,
                                k.HospitalLogo,
                            }).Where(x => x.EmpId == EMPid && x.Password == password).FirstOrDefault();

                if(list!=null)
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
