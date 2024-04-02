using AdminApi.Models.App.Bhaktas;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Horoscope;
using AdminApi.DTO.App.BhaktaDTO;
using AdminApi.Models.Helper;
using System.Linq;
using System;
using AdminApi.DTO.App.HoroscopeDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HoroscopeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Horoscope> _HoroscopeRepo;

        public HoroscopeController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Horoscope> horoscopeRepo)
        {
            _config = config;
            _context = context;
            _HoroscopeRepo = horoscopeRepo;
        }

        ///<summary>
        ///Create Horoscope
        ///</summary>
        [HttpPost]
        public IActionResult HoroscopeCreate(CreateHoroscopeDTO createHoroscopeDTO)
        {
            
            try
            {
              
                    Horoscope horoscope = new Horoscope();

                    horoscope.BhaktaId = createHoroscopeDTO.BhaktaId;
                    horoscope.PanditId = createHoroscopeDTO.PanditId;
                    horoscope.Zodiac = createHoroscopeDTO.Zodiac;
                    horoscope.DateOfBirth = createHoroscopeDTO.DateOfBirth;
                    horoscope.Question = createHoroscopeDTO.Question;
                    horoscope.Address = createHoroscopeDTO.Address;
                    horoscope.PrimaryPhone = createHoroscopeDTO.PrimaryPhone;
                    horoscope.AlternatePhone = createHoroscopeDTO.AlternatePhone;
                    horoscope.Price = createHoroscopeDTO.Price;

                    horoscope.CreatedBy = createHoroscopeDTO.CreatedBy;
                    horoscope.CreatedOn = System.DateTime.Now;
                    var obj = _HoroscopeRepo.Insert(horoscope);
                    return Ok(obj);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        ///<summary>
        ///Update Horoscope
        ///</summary>
        [HttpPost]
        public ActionResult UpdateHoroscope(UpdateHoroscopeDTO updateHoroscopeDTO)
        {
            try
            {
                var objHoroscope = _context.Horoscopes.SingleOrDefault(opt => opt.HoroscopeId == updateHoroscopeDTO.HoroscopeId);

                objHoroscope.BhaktaId = updateHoroscopeDTO.BhaktaId;
                objHoroscope.PanditId = updateHoroscopeDTO.PanditId;
                objHoroscope.Zodiac = updateHoroscopeDTO.Zodiac;
                objHoroscope.DateOfBirth = updateHoroscopeDTO.DateOfBirth;
                objHoroscope.Question = updateHoroscopeDTO.Question;
                objHoroscope.Address = updateHoroscopeDTO.Address;
                objHoroscope.PrimaryPhone = updateHoroscopeDTO.PrimaryPhone;
                objHoroscope.AlternatePhone = updateHoroscopeDTO.AlternatePhone;
                objHoroscope.Price = updateHoroscopeDTO.Price;


                objHoroscope.UpdatedBy = updateHoroscopeDTO.UpdatedBy;
                objHoroscope.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objHoroscope);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Get Horoscope List
        ///</summary>
        [HttpGet]
        public ActionResult GetHoroscopeList()
        {
            try
            {
                var list = (from u in _context.Horoscopes
                            join p in _context.Bhaktas on u.BhaktaId equals p.BhaktaId
                            join q in _context.Pandits on u.PanditId equals q.PanditId

                            select new
                            {
                                u.HoroscopeId,
                                u.BhaktaId,
                                p.BhaktaName,
                                u.PanditId,
                                q.PanditName,
                                u.Zodiac,
                                u.DateOfBirth,
                                u.Question,
                                u.Address,
                                u.PrimaryPhone,
                                u.AlternatePhone,
                                u.Price,
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
        ///Get Single Horoscope by ID
        ///</summary>
        [HttpGet("{HoroscopeId}")]
        public ActionResult GetSingleHoroscope(int HoroscopeId)
        {
            try
            {
                var singleHoroscope = _HoroscopeRepo.SelectById(HoroscopeId);
                return Ok(singleHoroscope);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Delete Single Horoscope by ID
        ///</summary>
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteHoroscope(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Horoscopes.SingleOrDefault(opt => opt.HoroscopeId == Id);
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

        ///<summary>
        ///Get Horoscope List by Bhakta ID 
        ///</summary>
        [HttpGet("{BhaktaId}")]
        public ActionResult GetHoroscopeListbyBhaktaId(int BhaktaId)
        {
            try
            {
                var list = (from u in _context.Horoscopes
                            join b in _context.Bhaktas on u.BhaktaId equals b.BhaktaId
                            join p in _context.Pandits on u.PanditId equals p.PanditId

                            select new
                            {
                                u.BhaktaId,
                                b.BhaktaName,
                                u.PanditId,
                                p.PanditName,
                                u.Zodiac,
                                u.DateOfBirth,
                                u.Question,
                                u.Address,
                                u.PrimaryPhone,
                                u.AlternatePhone,
                                u.Price,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.BhaktaId == BhaktaId).Distinct().ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Get Horoscope List by Pandit ID 
        ///</summary>
        [HttpGet("{PanditId}")]
        public ActionResult GetHoroscopeListbyPanditId(int PanditId)
        {
            try
            {
                var list = (from u in _context.Horoscopes
                            join b in _context.Bhaktas on u.BhaktaId equals b.BhaktaId
                            join p in _context.Pandits on u.PanditId equals p.PanditId

                            select new
                            {
                                u.BhaktaId,
                                b.BhaktaName,
                                u.PanditId,
                                p.PanditName,
                                u.Zodiac,
                                u.DateOfBirth,
                                u.Question,
                                u.Address,
                                u.PrimaryPhone,
                                u.AlternatePhone,
                                u.Price,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.PanditId == PanditId).Distinct().ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

    }
}
