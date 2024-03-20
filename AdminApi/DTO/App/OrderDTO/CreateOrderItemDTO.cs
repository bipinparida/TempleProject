namespace AdminApi.DTO.App.OrderDTO
{
    public class CreateOrderItemDTO
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateOrderItemDTO
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public int UpdatedBy { get; set; }
    }
}
