using System;

namespace AdminApi.Models.App.Booking
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int BhaktaId { get; set; }
        public int TempleId { get; set; }
        public int PoojaCategoryTypeId { get; set; }
        public int PoojaCategoryId { get; set; }
        public int PoojaCategoryItemId { get; set; }
        public int PanditId { get; set; }
      
        public DateTime? BookingDate { get; set; }
        public double? PoojaPrice { get; set; }


        public int CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
