namespace AdminApi.DTO.App.PoojaCategoryDTO
{
	public class CreatePoojaCategoryDTO
	{
		public string PoojaCategoryName { get; set; }
		public int CreatedBy { get; set; }
	}

	public class UpdatePoojaCategoryDTO
	{
		public int PoojaCategoryId { get; set; }
		public string PoojaCategoryName { get; set; }
		public int CreatedBy { get; set; }
	}

}
