using System;

namespace AdminApi.Models.App.Orders
{
    public class Address
    {
        public int AddressId { get; set; }
        public string FullName { get; set; }
        public string Pincode { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public string CityName { get; set; }
        public string PrimaryPhone { get; set; }
        public string AlternatePhone { get; set; }
        public string MailId { get; set; }
        public string HouseNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string LandMark { get; set; }


        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
