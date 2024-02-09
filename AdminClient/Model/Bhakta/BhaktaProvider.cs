using AdminClient.DTO;
using AdminClient.Model.Utility;
using Newtonsoft.Json;
using System;

namespace AdminClient.Model.Bhakta
{
	public class BhaktaProvider : IBhakta
	{
		IHttpWebClients _objIHttpWebClients;
		public BhaktaProvider(IHttpWebClients objIHttpWebClients)
		{
			_objIHttpWebClients = objIHttpWebClients;
		}
		public BhaktaViewModel BhaktaCreate(BhaktaNewDTO bhaktaNewDTO)
		{
			try
			{
				BhaktaViewModel objupdateResults = new BhaktaViewModel();
				objupdateResults = JsonConvert.DeserializeObject<BhaktaViewModel>(_objIHttpWebClients.PostRequest("/api/Bhakta/BhaktaCreate", JsonConvert.SerializeObject(bhaktaNewDTO), true));
				return objupdateResults;
			}
			catch (Exception)
			{
				throw;

			}
		}
	}
}
