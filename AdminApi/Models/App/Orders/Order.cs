using System;

namespace AdminApi.Models.App.Orders
{
    public class Order
    {
        public int OrderId { get; set; }
        public int AddressId { get; set; }
        public int TotalQuantity { get; set; }
        public double TotalAmount { get; set; }


        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
