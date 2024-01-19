using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Models.App
{
    public class DIETMaster
    {
        public int DIETMasterId { get; set; }
        public string PatientName { get; set; }
        public int? HospitalMasterid { get; set; }
        public string FloorsName { get; set; }
        public int? BedId { get; set; }
        public int PatientTypeId { get; set; }
        public int FoodServiceTypeId { get; set; }
        public int? DietTypeId { get; set; }
        public string SpecialInstruction { get; set; }
        public string status { get; set; }
        public string Feedback { get; set; }
        public DateTime? PlateReciveDate { get; set; }
        public DateTime? PlateDeliverDate { get; set; }
        public DateTime? PlateCollectionDate { get; set; }
        public int? FoodProviderLoginId { get; set; }
        public int? SupervisorId { get; set; }
        public string IP { get; set; }
        public string PatientStatus { get; set; }
        public DateTime? DietDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public int? DeletedBy { get; set; }


    }
}
