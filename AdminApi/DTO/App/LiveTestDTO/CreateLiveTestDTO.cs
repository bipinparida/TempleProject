using System.Collections.Generic;

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

        public int UpdatedBy { get; set; }
    }


    //public class CreateLiveTestDTOs
    //{
    //    public int PanditId { get; set; }
    //    public List<QuestionAnswerPair> QuestionAnswerPairs { get; set; }
    //    public int CreatedBy { get; set; }
    //}

    //public class QuestionAnswerPair
    //{
    //    public int QuestionId { get; set; }
    //    public string LiveTestAnswer { get; set; }
    //}


}
