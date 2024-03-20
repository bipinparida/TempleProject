namespace AdminApi.DTO.App.BannerDTO
{
    public class CreateBannerDTO
    {
        public string BannerName { get; set; }
        public string? BannerImage { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateBannerDTO
    {
        public int BannerId { get; set; }
        public string BannerName { get; set; }
        public string? BannerImage { get; set; }
        public int UpdatedBy { get; set; }
    }
}
