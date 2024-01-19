using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class HospitalMasterDTO
    {
        public string HospitalName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonNo { get; set; }
        public string MobileNo { get; set; }
        public string FloorNo { get; set; }
        public string HospitalLogo { get; set; }
        public int CreatedBy { get; set; }
    }
    public class HospitalMasterUpdateDTO
    {
        public int HospitalMasterid { get; set; }
        public string HospitalName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonNo { get; set; }
        public string MobileNo { get; set; }
        public string FloorNo { get; set; }
        public string HospitalLogo { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
