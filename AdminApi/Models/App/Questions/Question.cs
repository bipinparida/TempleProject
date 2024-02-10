using System;

namespace AdminApi.Models.App.Questions
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionName { get; set; }

        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
