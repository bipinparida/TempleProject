namespace AdminApi.DTO.App.FeedbackDTO
{
    public class CreateFeedbackDTO
    {
        public int BhaktaId { get; set; }
        public int PanditId { get; set; }
        public string FeedbackMessage { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateFeedbackDTO
    {
        public int FeedbackId { get; set; }
        public int BhaktaId { get; set; }
        public int PanditId { get; set; }
        public string FeedbackMessage { get; set; }
        public int CreatedBy { get; set; }
    }
}
