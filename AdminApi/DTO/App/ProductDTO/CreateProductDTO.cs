namespace AdminApi.DTO.App.ProductDTO
{
    public class CreateProductDTO
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
        public string Description { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateProductDTO
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
        public string Description { get; set; }
        public int UpdatedBy { get; set; }
    }
}
