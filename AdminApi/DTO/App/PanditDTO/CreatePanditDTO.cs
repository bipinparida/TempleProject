using System;

namespace AdminApi.DTO.App.PanditDTO
{
    public class CreatePanditDTO
    {
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string Experiences { get; set; }
        public string PujaCategory { get; set; }
        public string Religion { get; set; }
        public string MotherTongue { get; set; }
        public string Caste { get; set; }
        public string Gothram { get; set; }
        public string AadharCard { get; set; }
        public string Qualification { get; set; }
        public Int64 TempleId { get; set; }
        public string PanditName { get; set; }
        public string Address { get; set; }
        public string PrimaryPhone { get; set; }
        public string AlternatePhone { get; set; }
        public string MailId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
        public string PanditImage { get; set; }
        public string Message { get; set; }
        public bool Reject { get; set; }
        public bool IsApprove { get; set; }
        public int CreatedBy { get; set; }
    }

    public class UpdatePanditDTO
    {
        public Int64 PanditId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public string Experiences { get; set; }
        public string PujaCategory { get; set; }
        public string Religion { get; set; }
        public string MotherTongue { get; set; }
        public string Caste { get; set; }
        public string Gothram { get; set; }
        public string AadharCard { get; set; }
        public string Qualification { get; set; }
        public Int64 TempleId { get; set; }
        public string PanditName { get; set; }
        public string Address { get; set; }
        public string PrimaryPhone { get; set; }
        public string AlternatePhone { get; set; }
        public string MailId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
        public string PanditImage { get; set; }
        public string Message { get; set; }
        public bool Reject { get; set; }
        public bool IsApprove { get; set; }

        public int CreatedBy { get; set; }
    }
}
