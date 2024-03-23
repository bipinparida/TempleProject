using AdminClient.DTO;
using AdminClient.Model.Utility;
using Newtonsoft.Json;
using System;

namespace AdminClient.Model.Product
{
	public class ProductProvider : IProduct
	{
		IHttpWebClients _objIHttpWebClients;
		public ProductProvider(IHttpWebClients objIHttpWebClients)
		{
			_objIHttpWebClients = objIHttpWebClients;
		}
		public ProductViewModel ProductCreate(ProductNewDTO productNewDTO)
		{
			try
			{
				ProductViewModel objupdateResults = new ProductViewModel();
				objupdateResults = JsonConvert.DeserializeObject<ProductViewModel>(_objIHttpWebClients.PostRequest("/api/Product/ProductCreate", JsonConvert.SerializeObject(productNewDTO), true));
				return objupdateResults;
			}
			catch (Exception)
			{
				throw;

			}
		}
	}
}
