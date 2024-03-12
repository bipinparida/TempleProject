using System.Collections.Generic;

namespace AdminApi.DTO.App.PoojaCategoryDTO
{
    public class CreatePoojaCategoryMappingDTO
    {
        public int TempleId { get; set; }
        public int PanditId { get; set; }
        public int PoojaCategoryTypeId { get; set; }
        public int PoojaCategoryId { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdatePoojaCategoryMappingDTO
    {
        public int PoojaCategoryMappingId { get; set; }
        public int TempleId { get; set; }
        public int PanditId { get; set; }
        public int PoojaCategoryTypeId { get; set; }
        public int PoojaCategoryId { get; set; }
        public int UpdatedBy { get; set; }
    }
    public class PoojaCategoryMappingMasterDTOs
    {
        public List<CreatePoojaCategoryMappingDTO> PoojaCategoryMappings { get; set; } 
    }

   
}
