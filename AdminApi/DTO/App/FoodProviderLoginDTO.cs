namespace AdminApi.DTO.App
{
    public class FoodProviderLoginDTO
    {
        public int HospitalMasterid { get; set; }
        public string FoodProviderName { get; set; }
        public string MobileNo { get; set; }
        public string EmpId { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public int CreatedBy { get; set; }
    }
    public class FoodProviderLoginUpdateDTO
    {
        public int HospitalMasterid { get; set; }
        public int FoodProviderLoginId { get; set; }
        public string FoodProviderName { get; set; }
        public string MobileNo { get; set; }
        public string EmpId { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public int? UpdatedBy { get; set; }
    }
    public class userloginDTO
    {
        public int FoodProviderLoginId { get; set; }
        public string EmpId { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
    }
}
