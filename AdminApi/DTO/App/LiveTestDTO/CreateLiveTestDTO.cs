namespace AdminApi.DTO.App.LiveTestDTO
{
    public class CreateLiveTestDTO
    {
        public int PanditId { get; set; }
        public int QuestionId { get; set; }
        public string LiveTestAnswer { get; set; }

        public int CreatedBy { get; set; }
    }

    public class UpdateLiveTestDTO
    {
        public int LiveTestId { get; set; }
        public int PanditId { get; set; }
        public int QuestionId { get; set; }
        public string LiveTestAnswer { get; set; }

        public int CreatedBy { get; set; }
    }

}
