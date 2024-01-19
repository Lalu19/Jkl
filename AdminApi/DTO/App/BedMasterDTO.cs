using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.DTO.App
{
    public class BedMasterDTO
    {
        public List<BedDTO> BedDTOs { get; set; }
    }
    public class BedDTO
    {
        public int FloorNoid { get; set; }
        public string FloorsName { get; set; }
        public string BedNo { get; set; }
        public int HospitalMasterid { get; set; }
        public string status { get; set; }
        public int CreatedBy { get; set; }
    }
    public class BedMasterUpdateDTO
    {
        public int BedMasterId { get; set; }
        public int FloorNoid { get; set; }
        public string FloorsName { get; set; }
        public string BedNo { get; set; }
        public int HospitalMasterid { get; set; }
        public string status { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
