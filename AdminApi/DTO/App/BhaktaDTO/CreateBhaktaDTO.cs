using System;

namespace AdminApi.DTO.App.BhaktaDTO
{
    public class CreateBhaktaDTO
    {
        public string BhaktaName { get; set; }
        public string Address { get; set; }
        public string PrimaryPhone { get; set; }
        public string AlternatePhone { get; set; }
        public string MailId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Password { get; set; }
        public string? BhaktaImage { get; set; }

        public int CreatedBy { get; set; }
    }
    public class UpdateBhaktaDTO
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

        public int UpdatedBy { get; set; }
    }
}
