using System;

namespace AdminApi.Models.App.Checkouts
{
    public class Checkout
    {
        public int CheckoutId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
