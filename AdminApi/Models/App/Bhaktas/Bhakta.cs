using System;

namespace AdminApi.Models.App.Bhaktas
{
    public class Bhakta
    {
        public int BhaktaId { get; set; }
        public string BhaktaName { get; set; }
        public string Address { get; set; }
        public string PrimaryPhone { get; set; }
        public string AlternatePhone { get; set; }
        public string MailId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Password { get; set; }
        public string? BhaktaImage { get; set; }

        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
