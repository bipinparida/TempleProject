using AdminClient.DTO;
using AdminClient.Model.Utility;
using Newtonsoft.Json;
using System;

namespace AdminClient.Model.Pandit
{
    public class PanditProvider : IPandit
    {
        IHttpWebClients _objIHttpWebClients;
        public PanditProvider(IHttpWebClients objIHttpWebClients)
        {
            _objIHttpWebClients = objIHttpWebClients;
        }

        public PanditViewModel PanditCreate(PanditNewDTO panditNewDTO)
        {
            try
            {
                PanditViewModel objupdateResults = new PanditViewModel();
                objupdateResults = JsonConvert.DeserializeObject<PanditViewModel>(_objIHttpWebClients.PostRequest("/api/Pandit/PanditCreate", JsonConvert.SerializeObject(panditNewDTO), true));
                return objupdateResults;
            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
