namespace AdminApi.DTO.App.PoojaCategoryDTO
{
    public class CreatePoojaCategoryTypeDTO
    {
        public string PoojaCategoryTypeName { get; set; }
        public string? PoojaCategoryTypeImage { get; set; }

        public int CreatedBy { get; set; }
    }

    public class UpdatePoojaCategoryTypeDTO
    {
        public int PoojaCategoryTypeId { get; set; }
        public string PoojaCategoryTypeName { get; set; }
        public string? PoojaCategoryTypeImage { get; set; }

        public int UpdatedBy { get; set; }

    }

}
