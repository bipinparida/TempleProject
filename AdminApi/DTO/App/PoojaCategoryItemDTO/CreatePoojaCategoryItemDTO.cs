using System.Collections.Generic;

namespace AdminApi.DTO.App.PoojaCategoryItemDTO
{
    public class CreatePoojaCategoryItemDTO
    {
        public int TempleId { get; set; }
        public int PoojaCategoryId { get; set; }
        public string ItemName { get; set; }
        public double? ItemPrice { get; set; }

        public int CreatedBy { get; set; }
    }
    public class UpdatePoojaCategoryItemDTO
    {
        public int PoojaCategoryItemId { get; set; }
        public int TempleId { get; set; }
        public int PoojaCategoryId { get; set; }
        public string ItemName { get; set; }
        public double? ItemPrice { get; set; }

        public int UpdatedBy { get; set; }
    }
    public class PoojaCategoryItemMasterDTO
    {
        public List<CreatePoojaCategoryItemDTO> CreatePoojaCategoryItemDTOs { get; set; }
    }
}
