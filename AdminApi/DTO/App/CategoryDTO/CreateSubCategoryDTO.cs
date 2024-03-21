namespace AdminApi.DTO.App.CategoryDTO
{
    public class CreateSubCategoryDTO
    {
        public int CategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string? SubCategoryImage { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateSubCategoryDTO
    {
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string? SubCategoryImage { get; set; }
        public int UpdatedBy { get; set; }
    }
}
