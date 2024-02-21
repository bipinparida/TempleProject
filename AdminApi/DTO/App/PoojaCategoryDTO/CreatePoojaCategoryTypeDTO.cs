namespace AdminApi.DTO.App.PoojaCategoryDTO
{
    public class CreatePoojaCategoryTypeDTO
    {
        public string PoojaCategoryTypeName { get; set; }

        public int CreatedBy { get; set; }
    }

    public class UpdatePoojaCategoryTypeDTO
    {
        public int PoojaCategoryTypeId { get; set; }
        public string PoojaCategoryTypeName { get; set; }

        public int CreatedBy { get; set; }

    }

}
