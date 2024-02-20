namespace AdminApi.DTO.App.PoojaCategoryDTO
{
    public class CreatePoojaCategoryMappingDTO
    {
        public int TempleId { get; set; }
        public int PoojaCategoryId { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdatePoojaCategoryMappingDTO
    {
        public int PoojaCategoryMappingId { get; set; }
        public int TempleId { get; set; }
        public int PoojaCategoryId { get; set; }
        public int CreatedBy { get; set; }
    }
}
