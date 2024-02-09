using System;

namespace AdminApi.Models.App.PoojaCategory
{
	public class PoojaCategory
	{
		public int PoojaCategoryId { get; set; }
		public string PoojaCategoryName { get; set; }

		public int CreatedBy { get; set; }
		public DateTime? CreatedOn { get; set; }
		public int? UpdatedBy { get; set; }
		public DateTime? UpdatedOn { get; set; }
		public bool IsDeleted { get; set; }
	}
}
