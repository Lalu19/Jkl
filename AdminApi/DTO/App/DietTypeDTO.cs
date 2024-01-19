namespace AdminApi.DTO.App
{
    public class DietTypeDTO
    {
        public string DietTypeName { get; set; }
        public int CreatedBy { get; set; }
    }
    public class DietTypeUpdateDTO
    {
        public int DietTypeId { get; set; }
        public string DietTypeName { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
