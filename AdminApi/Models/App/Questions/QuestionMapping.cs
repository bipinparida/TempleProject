using System;

namespace AdminApi.Models.App.Questions
{
    public class QuestionMapping
    {
        public int QuestionMappingId { get; set; }
        public int PanditId { get; set; }
        public int QuestionId { get; set; }

        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
