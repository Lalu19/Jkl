using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Models.App
{
    public class BedMaster
    {
        public int BedMasterId { get; set; }
        public int FloorNoid { get; set; }
        public string FloorsName { get; set; }
        public string BedNo { get; set; }
        public string status { get; set; }
        public int OcupiedId { get; set; }
        public int HospitalMasterid { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
