using AdminApi.DTO.App.PoojaCategoryItemDTO;
using System.Collections.Generic;

namespace AdminApi.DTO.App.PoojaCategoryDTO
{
	public class CreatePoojaCategoryDTO
	{
        public int TempleId { get; set; }
        public int PoojaCategoryTypeId { get; set; }
        public string PoojaCategoryName { get; set; }
		public int CreatedBy { get; set; }
	}

	public class UpdatePoojaCategoryDTO
	{
		public int PoojaCategoryId { get; set; }
        public int TempleId { get; set; }
        public int PoojaCategoryTypeId { get; set; }
        public string PoojaCategoryName { get; set; }
		public int UpdatedBy { get; set; }
	}
    public class PoojaCategoryMasterDTO
	{
        public List<CreatePoojaCategoryDTO> CreatePoojaCategoryDTOs { get; set; }
    }

}
