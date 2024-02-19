namespace AdminApi.DTO.App.PoojaCategoryDTO
{
    public class CreateTemplePoojaCategoryDTO
    {
        public int TempleId { get; set; }
        public int PoojaCategoryId { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateTemplePoojaCategoryDTO
    {
        public int TemplePoojaCategoryId { get; set; }
        public int TempleId { get; set; }
        public int PoojaCategoryId { get; set; }
        public int CreatedBy { get; set; }
    }
}
