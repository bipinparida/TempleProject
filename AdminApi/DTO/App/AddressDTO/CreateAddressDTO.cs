namespace AdminApi.DTO.App.AddressDTO
{
    public class CreateAddressDTO
    {
        public string Name { get; set; }
        public string Pincode { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public string PrimaryPhone { get; set; }
        public string AlternatePhone { get; set; }
        public string MailId { get; set; }
        public string HouseNumber { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateAddressDTO
    {
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string Pincode { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? CityId { get; set; }
        public string PrimaryPhone { get; set; }
        public string AlternatePhone { get; set; }
        public string MailId { get; set; }
        public string HouseNumber { get; set; }
        public int UpdatedBy { get; set; }
    }
}
