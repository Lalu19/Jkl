namespace AdminApi.DTO.App
{
    public class FoodServiceTypeDTO
    {
        public string FoodServiceTypeName { get; set; }
        public int CreatedBy { get; set; }
    }
    public class FoodServiceTypeUpdateDTO
    {
        public int FoodServiceTypeId { get; set; }
        public string FoodServiceTypeName { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
