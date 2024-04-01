using System;

namespace AdminApi.DTO.App.BookingDTO
{
    public class CreateBookingDTO
    {
        public int BhaktaId { get; set; }
        public int TempleId { get; set; }
        public int PoojaCategoryTypeId { get; set; }
        public int PoojaCategoryId { get; set; }
        public int PoojaCategoryItemId { get; set; }
        public int PanditId { get; set; }
        public bool IsComplete { get; set; }

        public DateTime? BookingDate { get; set; }
        public double? PoojaPrice { get; set; }

        public int CreatedBy { get; set; }
    }

    public class UpdateBookingDTO
    {
        public int BookingId { get; set; }
        public int BhaktaId { get; set; }
        public int TempleId { get; set; }
        public int PoojaCategoryTypeId { get; set; }
        public int PoojaCategoryId { get; set; }
        public int PoojaCategoryItemId { get; set; }
        public int PanditId { get; set; }
        public bool IsComplete { get; set; }

        public DateTime? BookingDate { get; set; }
        public double? PoojaPrice { get; set; }

        public int UpdatedBy { get; set; }
    }

}
