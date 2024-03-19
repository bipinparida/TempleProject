using System;

namespace AdminApi.Models.App.Orders
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderParentId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }

        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
