using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace AdminClient.DTO
{
	public class ProductDTO
	{
		public int? TempleId { get; set; }
		public int? PanditId { get; set; }
		public int CategoryId { get; set; }
		public int SubCategoryId { get; set; }
		public string ProductName { get; set; }
		public double SalePrice { get; set; }
		public double MRP { get; set; }
		public double? DiscountAmount { get; set; }
		public string Thumbnail { get; set; }
		public string Image { get; set; }

        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }

        //public List<string> Image { get; set; } = new List<string>(); 

        public string Description { get; set; }
		public int CreatedBy { get; set; }

        public IFormFile file { get; set; }
        public IFormFile file1 { get; set; }
        public IFormFile file2 { get; set; }
        public IFormFile file3 { get; set; }
        public IFormFile file4 { get; set; }
        public List<IFormFile> files { get; set; } = new List<IFormFile>(); // For multiple images
	}

	public class ProductViewModel
	{
		public int ProductId { get; set; }
		public int? TempleId { get; set; }
		public int? PanditId { get; set; }
		public int CategoryId { get; set; }
		public int SubCategoryId { get; set; }
		public string ProductName { get; set; }
		public double SalePrice { get; set; }
		public double MRP { get; set; }
		public double? DiscountAmount { get; set; }
		public string Thumbnail { get; set; }
		public string Image { get; set; }

        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }

        //public List<string> Image { get; set; } = new List<string>(); 
        public string Description { get; set; }
		public int CreatedBy { get; set; }

	}

	public class ProductNewDTO
	{
		public int? TempleId { get; set; }
		public int? PanditId { get; set; }
		public int CategoryId { get; set; }
		public int SubCategoryId { get; set; }
		public string ProductName { get; set; }
		public double SalePrice { get; set; }
		public double MRP { get; set; }
		public double? DiscountAmount { get; set; }
		public string Thumbnail { get; set; }
		public string Image { get; set; }

        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }

        //public List<string> Image { get; set; } = new List<string>(); 
        public string Description { get; set; }
		public int CreatedBy { get; set; }

	}

}
