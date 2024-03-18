namespace AdminApi.DTO.App.CheckoutDTO
{
    public class CreateCheckoutDTO
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateCheckoutDTO
    {
        public int CheckoutId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int UpdatedBy { get; set; }
    }
}
