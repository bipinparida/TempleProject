using Microsoft.AspNetCore.Http;
using System;

namespace AdminClient.DTO
{
    public class PanditDTO
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
        public int TempleId { get; set; }
        public string PanditName { get; set; }
        public string Address { get; set; }
        public string PrimaryPhone { get; set; }
        public string AlternatePhone { get; set; }
        public string MailId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
        public string? PanditImage { get; set; }
        public string Message { get; set; }
        public bool Reject { get; set; }
        public bool IsApprove { get; set; }
        public int CreatedBy { get; set; }
        public IFormFile file { get; set; }
    }

    public class PanditViewModel
    {
        public int PanditId { get; set; }
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
        public int TempleId { get; set; }
        public string PanditName { get; set; }
        public string Address { get; set; }
        public string PrimaryPhone { get; set; }
        public string AlternatePhone { get; set; }
        public string MailId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
        public string? PanditImage { get; set; }
        public string Message { get; set; }
        public bool Reject { get; set; }
        public bool IsApprove { get; set; }

        public int CreatedBy { get; set; }
    }

    public class PanditNewDTO
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
        public int TempleId { get; set; }
        public string PanditName { get; set; }
        public string Address { get; set; }
        public string PrimaryPhone { get; set; }
        public string AlternatePhone { get; set; }
        public string MailId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Password { get; set; }
        public string? PanditImage { get; set; }
        public string Message { get; set; }
        public bool Reject { get; set; }
        public bool IsApprove { get; set; }
        public int CreatedBy { get; set; }
    }

}
