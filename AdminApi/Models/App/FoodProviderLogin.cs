
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AdminApi.Models.App
{
    public class FoodProviderLogin
    {
        public int FoodProviderLoginId { get; set; }
        public int HospitalMasterid { get; set; }
        public string FoodProviderName { get; set; }
        public string MobileNo { get; set; }
        public string EmpId { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
