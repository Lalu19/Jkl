using System;

namespace AdminApi.Models.App
{
    public class Supervisor
    {
        public int SupervisorId { get; set; }
        public int HospitalMasterid { get; set; }
        public string SupervisorName { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string EmployeeId { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
