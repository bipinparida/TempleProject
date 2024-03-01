using AdminApi.Models.App.Bhaktas;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Booking;
using AdminApi.DTO.App.BhaktaDTO;
using AdminApi.Models.Helper;
using System.Linq;
using System;
using AdminApi.DTO.App.BookingDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookingController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Booking> _BookingRepo;

        public BookingController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<Booking> bookingRepo)
        {
            _config = config;
            _context = context;
            _BookingRepo = bookingRepo;
        }

        ///<summary>
        ///Create Booking
        ///</summary>
        [HttpPost]
        public IActionResult BookingCreate(CreateBookingDTO createBookingDTO)
        {
            try
            {
                Booking booking = new Booking();

                booking.BhaktaId = createBookingDTO.BhaktaId;
                booking.TempleId = createBookingDTO.TempleId;
                booking.PanditId = createBookingDTO.PanditId;
                booking.PoojaCategoryId = createBookingDTO.PoojaCategoryId;
                booking.BookingDate = createBookingDTO.BookingDate;


                booking.CreatedBy = createBookingDTO.CreatedBy;
                booking.CreatedOn = System.DateTime.Now;
                var obj = _BookingRepo.Insert(booking);
                return Ok(obj);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }


        ///<summary>
        ///Get Booking List
        ///</summary>
        [HttpGet]
        public ActionResult GetBookingList()
        {
            try
            {
                var list = (from u in _context.Bookings
                            join b in _context.Bhaktas on u.BhaktaId equals b.BhaktaId
                            join t in _context.Temples on u.TempleId equals t.TempleId
                            join p in _context.Pandits on u.PanditId equals p.PanditId
                            join c in _context.PoojaCategories on u.PoojaCategoryId equals c.PoojaCategoryId

                            select new
                            {
                                u.BookingId,
                                u.BhaktaId,
                                b.BhaktaName,
                                u.TempleId,
                                t.TempleName,
                                u.PanditId,
                                p.PanditName,
                                u.PoojaCategoryId,
                                c.PoojaCategoryName,
                                u.BookingDate,

                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Get Single Booking by ID
        ///</summary>
        [HttpGet("{BookingId}")]
        public ActionResult GetSingleBooking(int BookingId)
        {
            try
            {
                var singleBooking = _BookingRepo.SelectById(BookingId);
                return Ok(singleBooking);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Update Booking
        ///</summary>
        [HttpPost]
        public ActionResult UpdateBooking(UpdateBookingDTO updateBookingDTO)
        {
            try
            {
                var objBooking = _context.Bookings.SingleOrDefault(opt => opt.BookingId == updateBookingDTO.BookingId);

                objBooking.BhaktaId = updateBookingDTO.BhaktaId;
                objBooking.TempleId = updateBookingDTO.TempleId;
                objBooking.PanditId = updateBookingDTO.PanditId;
                objBooking.PoojaCategoryId = updateBookingDTO.PoojaCategoryId;
                objBooking.BookingDate = updateBookingDTO.BookingDate;

                objBooking.UpdatedBy = updateBookingDTO.CreatedBy;
                objBooking.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objBooking);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Delete Single Booking by ID
        ///</summary>
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteBooking(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Bookings.SingleOrDefault(opt => opt.BookingId == Id);
                objabout.IsDeleted = true;
                objabout.UpdatedBy = DeletedBy;
                objabout.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objabout);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }




    }
}
