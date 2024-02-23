using System;

namespace AdminApi.Models.App.PoojaCategory
{
    public class PoojaCategoryMapping
    {
        public int PoojaCategoryMappingId { get; set; }
        public int TempleId { get; set; }
        public int PoojaCategoryTypeId { get; set; }
        public int PoojaCategoryId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
