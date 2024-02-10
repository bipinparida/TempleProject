namespace AdminApi.DTO.App.QuestionDTO
{
    public class CreateQuestionDTO
    {
        public string QuestionName { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateQuestionDTO
    {
        public int QuestionId { get; set; }
        public string QuestionName { get; set; }

        public int CreatedBy { get; set; }
    }
}
