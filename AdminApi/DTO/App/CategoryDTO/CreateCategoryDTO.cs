namespace AdminApi.DTO.App.CategoryDTO
{
    public class CreateCategoryDTO
    {
        public string CategoryName { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateCategoryDTO
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int UpdatedBy { get; set; }
    }
}
