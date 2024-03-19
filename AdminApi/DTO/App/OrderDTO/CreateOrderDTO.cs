namespace AdminApi.DTO.App.OrderDTO
{
    public class CreateOrderDTO
    {
        public int OrderParentId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateOrderDTO
    {
        public int OrderId { get; set; }
        public int OrderParentId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public int UpdatedBy { get; set; }
    }
}
