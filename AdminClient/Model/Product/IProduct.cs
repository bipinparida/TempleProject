using AdminClient.DTO;

namespace AdminClient.Model.Product
{
	public interface IProduct
	{
		public ProductViewModel ProductCreate(ProductNewDTO productNewDTO);
	}
}
