using System;

namespace AdminApi.Models.App.Horoscope
{
    public class Horoscope
    {
        public int HoroscopeId { get; set; }
        public int BhaktaId { get; set; }
        public int PanditId { get; set; }
        public string Zodiac { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Question { get; set; }
        public double? Price { get; set; }
        public string Address { get; set; }
        public string PrimaryPhone { get; set; }
        public string AlternatePhone { get; set; }


        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
