using AdminClient.DTO;

namespace AdminClient.Model.LiveTest
{
    public interface ILiveTest
    {
        public LiveTestViewModel LiveTestCreate(LiveTestNewDTO liveTestNewDTO);
    }
}
