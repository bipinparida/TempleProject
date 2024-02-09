using AdminClient.DTO;

namespace AdminClient.Model.Bhakta
{
	public interface IBhakta
	{
		public BhaktaViewModel BhaktaCreate(BhaktaNewDTO bhaktaNewDTO);
	}
}
