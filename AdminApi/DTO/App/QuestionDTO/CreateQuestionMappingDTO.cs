namespace AdminApi.DTO.App.QuestionDTO
{
    public class CreateQuestionMappingDTO
    {
        public int PanditId { get; set; }
        public int QuestionId { get; set; }

        public int CreatedBy { get; set; }
    }

    public class UpdateQuestionMappingDTO
    {
        public int QuestionMappingId { get; set; }
        public int PanditId { get; set; }
        public int QuestionId { get; set; }

        public int CreatedBy { get; set; }
    }

}
