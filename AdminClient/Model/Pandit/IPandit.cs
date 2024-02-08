using AdminClient.DTO;

namespace AdminClient.Model.Pandit
{
    public interface IPandit
    {
        public PanditViewModel PanditCreate(PanditNewDTO panditNewDTO);
    }
}
