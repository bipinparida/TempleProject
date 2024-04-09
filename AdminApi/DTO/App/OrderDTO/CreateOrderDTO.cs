using System.Collections.Generic;

namespace AdminApi.DTO.App.OrderDTO
{
    public class CreateOrderDTO
    {
        public int AddressId { get; set; }
        public int TotalQuantity { get; set; }
        public double TotalAmount { get; set; }
        public int CreatedBy { get; set; }
        public List<CreateOrderItemDTO> CreateOrderItemDTOs { get; set; }
    }
    public class UpdateOrderDTO
    {
        public int OrderId { get; set; }
        public int AddressId { get; set; }
        public int TotalQuantity { get; set; }
        public double TotalAmount { get; set; }
        public int UpdatedBy { get; set; }
        public List<UpdateOrderItemDTO> UpdateOrderItemDTOs { get; set; }
    }
}
