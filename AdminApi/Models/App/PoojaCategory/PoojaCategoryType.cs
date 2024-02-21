using System;

namespace AdminApi.Models.App.PoojaCategory
{
    public class PoojaCategoryType
    {
        public int PoojaCategoryTypeId { get; set; }
        public string PoojaCategoryTypeName { get; set; }

        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
