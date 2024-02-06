namespace AdminApi.DTO.App.LocationDTO
{
    public class CreateCityDTO
    {
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public string CityName { get; set; }
        public int CreatedBy { get; set; }
    }
    public class UpdateCityDTO
    {
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public string CityName { get; set; }
        public int CreatedBy { get; set; }
    }

}
