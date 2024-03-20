using System;

namespace AdminApi.Models.App.Banner
{
    public class Banner
    {
        public int BannerId { get; set; }
        public string BannerName { get; set; }
        public string? BannerImage { get; set; }


        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
