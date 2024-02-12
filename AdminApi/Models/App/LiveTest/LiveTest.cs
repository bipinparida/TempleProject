using System;

namespace AdminApi.Models.App.LiveTest
{
    public class LiveTest
    {
        public int LiveTestId { get; set; }
        public int PanditId { get; set; }
        public int QuestionId { get; set; }
        public string LiveTestAnswer { get; set; }

        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
