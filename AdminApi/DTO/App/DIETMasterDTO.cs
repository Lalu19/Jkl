using System;
using System.Collections.Generic;

namespace AdminApi.DTO.App
{
    public class DIETMasterDTO
    {
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
        public string IP { get; set; }
        public string PatientStatus { get; set; }
        public DateTime? DietDate { get; set; }
        public int CreatedBy { get; set; }
    }

    public class DietUpdateDTO
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
        public string IP { get; set; }
        public string PatientStatus { get; set; }
        public DateTime? DietDate { get; set; }
        public int? UpdatedBy { get; set; }
    }

    public class FoodScanDTO
    {
        public int DIETMasterId { get; set; }
        public int FoodProviderLoginId { get; set; }

    }
    public class FeedbackDTO
    {
        public int DIETMasterId { get; set; }

    }

    public class AssigneeFoodProviderDTO
    {
        public List<string> dietMasterId { get; set; }
        public int FoodProviderLoginId { get; set; }
        public int SupervisorId { get; set; }

    }
    public class AddFoodProviderDTO
    {
        public int DIETMasterId { get; set; }
       

    }
    

}
