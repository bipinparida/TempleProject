using System;

namespace AdminApi.DTO.App.TempleDTO
{
    public class CreateTempleDTO
    {
        public string TempleName { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string GodName { get; set; }
        public string TempleImage { get; set; }

        public int CreatedBy { get; set; }
    }

    public class UpdateTempleDTO
    {
        public Int64 TempleId { get; set; }
        public string TempleName { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public string GodName { get; set; }
        public string TempleImage { get; set; }

        public int CreatedBy { get; set; }
    }
}
