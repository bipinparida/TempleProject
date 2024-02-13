using AdminClient.DTO;
using AdminClient.Model.Utility;
using Newtonsoft.Json;
using System;

namespace AdminClient.Model.LiveTest
{
    public class LiveTestProvider :ILiveTest
    {
        IHttpWebClients _objIHttpWebClients;
        public LiveTestProvider(IHttpWebClients objIHttpWebClients)
        {
            _objIHttpWebClients = objIHttpWebClients;
        }

        public LiveTestViewModel LiveTestCreate(LiveTestNewDTO liveTestNewDTO)
        {
            try
            {
                LiveTestViewModel objupdateResults = new LiveTestViewModel();
                objupdateResults = JsonConvert.DeserializeObject<LiveTestViewModel>(_objIHttpWebClients.PostRequest("/api/LiveTest/LiveTestCreate", JsonConvert.SerializeObject(liveTestNewDTO), true));
                return objupdateResults;
            }
            catch (Exception)
            {
                throw;

            }
        }
    }
}
