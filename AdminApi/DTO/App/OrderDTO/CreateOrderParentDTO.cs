using AdminApi.DTO.App.PoojaCategoryDTO;
using System.Collections.Generic;

namespace AdminApi.DTO.App.OrderDTO
{
    public class CreateOrderParentDTO
    {
        public int BhaktaId { get; set; }
        public int TotalQuantity { get; set; }
        public double TotalAmount { get; set; }
        public int CreatedBy { get; set; }
        public List<CreateOrderDTO> CreateOrderDTOs { get; set; }
    }
    public class UpdateOrderParentDTO
    {
        public int OrderParentId { get; set; }
        public int BhaktaId { get; set; }
        public int TotalQuantity { get; set; }
        public double TotalAmount { get; set; }
        public int UpdatedBy { get; set; }
        public List<UpdateOrderDTO> UpdateOrderDTOs { get; set; }
    }
}
