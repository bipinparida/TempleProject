using System;

namespace AdminApi.Models.App.Orders
{
    public class OrderParent
    {
        public int OrderParentId { get; set; }
        public int BhaktaId { get; set; }
        public int TotalQuantity { get; set; }
        public double TotalAmount { get; set; }


        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
