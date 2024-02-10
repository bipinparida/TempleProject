using System;

namespace AdminApi.Models.App.Feedbacks
{
    public class Feedback
    {

        public int FeedbackId { get; set; }
        public int BhaktaId { get; set; }
        public int PanditId { get; set; }
        public string FeedbackMessage { get; set; }

        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
