using System;

namespace AdminApi.Models.App.PoojaCategoryItems
{
    public class PoojaCategoryItem
    {
        public int PoojaCategoryItemId { get; set; }
        public int TempleId { get; set; }
        public int PoojaCategoryId { get; set; }
        public string ItemName { get; set; }
        public double? ItemPrice { get; set; }

        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
