using System;

namespace AdminApi.DTO.App.BookingDTO
{
    public class CreateBookingDTO
    {
        public int BhaktaId { get; set; }
        public int TempleId { get; set; }
        public int PanditId { get; set; }
        public int PoojaCategoryId { get; set; }
        public DateTime? BookingDate { get; set; }

        public int CreatedBy { get; set; }
    }

    public class UpdateBookingDTO
    {
        public int BookingId { get; set; }
        public int BhaktaId { get; set; }
        public int TempleId { get; set; }
        public int PanditId { get; set; }
        public int PoojaCategoryId { get; set; }
        public DateTime? BookingDate { get; set; }

        public int CreatedBy { get; set; }
    }

}
