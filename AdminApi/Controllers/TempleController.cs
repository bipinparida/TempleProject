using AdminApi.Models;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using AdminApi.DTO.App.TempleDTO;
using AdminApi.Models.App.Temples;
using AdminApi.DTO.App.LocationDTO;
using Microsoft.EntityFrameworkCore;


namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TempleController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Temple> _TempleRepo;

        public TempleController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<Temple> templeRepo)
        {
            _config = config;
            _context = context;
            _TempleRepo = templeRepo;
        }

        ///<summary>
        ///Create Temple
        ///</summary>
        [HttpPost]
        public IActionResult TempleCreate(CreateTempleDTO createTempleDTO)
        {
            var objcheck = _context.Temples.SingleOrDefault(opt => opt.TempleName == createTempleDTO.TempleName && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    Temple temple = new Temple();

                    temple.TempleName = createTempleDTO.TempleName;
                    temple.CountryId = createTempleDTO.CountryId;
                    temple.StateId = createTempleDTO.StateId;
                    temple.CityId = createTempleDTO.CityId;
                    temple.GodName = createTempleDTO.GodName;
                    temple.TempleImage = createTempleDTO.TempleImage;

                    temple.CreatedBy = createTempleDTO.CreatedBy;
                    temple.CreatedOn = System.DateTime.Now;
                    var obj = _TempleRepo.Insert(temple);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Temple..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        ///<summary>
        ///Get Temple List
        ///</summary>
        [HttpGet]
        public ActionResult GetTempleList()
        {
            try
            {
                var list = (from u in _context.Temples
                            join c in _context.Countries on u.CountryId equals c.CountryId
                            join s in _context.States on u.StateId equals s.StateId
                            join d in _context.Cities on u.CityId equals d.CityId

                            select new
                            {
                                u.TempleId,
                                u.TempleName,
                                u.CountryId,
                                c.CountryName,
                                u.StateId,
                                s.StateName,
                                u.CityId,
                                d.CityName,
                                u.GodName,
                                u.TempleImage,
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
        ///Get Single Temple by ID
        ///</summary>
        [HttpGet("{TempleId}")]
        public ActionResult GetSingleTemple(int TempleId)
        {
            try
            {
                var singleTemple = _TempleRepo.SelectById(TempleId);
                return Ok(singleTemple);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Update Temple
        ///</summary>
        [HttpPost]
        public ActionResult UpdateTemple(UpdateTempleDTO updateTempleDTO)
        {
            try
            {
                var objTemple = _context.Temples.SingleOrDefault(opt => opt.TempleId == updateTempleDTO.TempleId);

                var existingTemple = _context.Temples.SingleOrDefault(opt => opt.TempleName == updateTempleDTO.TempleName && opt.TempleId != updateTempleDTO.TempleId && opt.IsDeleted == false);

                if (existingTemple != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate TempleName..!" });
                }
                objTemple.TempleName = updateTempleDTO.TempleName;
                objTemple.CountryId = updateTempleDTO.CountryId;
                objTemple.StateId = updateTempleDTO.StateId;
                objTemple.CityId = updateTempleDTO.CityId;
                objTemple.GodName = updateTempleDTO.GodName;
                objTemple.TempleImage = updateTempleDTO.TempleImage;

                objTemple.UpdatedBy = updateTempleDTO.CreatedBy;
                objTemple.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objTemple);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Delete Single Temple by ID
        ///</summary>

        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteTemple(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Temples.SingleOrDefault(opt => opt.TempleId == Id);
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
        ///Get Temple List by CountryId
        ///</summary>
        [HttpGet("{CountryId}")]
        public ActionResult GetTempleListbyCountryId(int CountryId)
        {
            try
            {
                var list = (from u in _context.Temples
                            join c in _context.Countries on u.CountryId equals c.CountryId

                            select new
                            {
                                u.TempleId,
                                u.TempleName,
                                u.GodName,
                                u.TempleImage,
                                u.CountryId,
                                c.CountryName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.CountryId == CountryId).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Get Temple List by StateId
        ///</summary>
        [HttpGet("{StateId}")]
        public ActionResult GetTempleListbyStateId(int StateId)
        {
            try
            {
                var list = (from u in _context.Temples
                            join c in _context.Countries on u.CountryId equals c.CountryId
                            join s in _context.States on u.StateId equals s.StateId

                            select new
                            {
                                u.TempleId,
                                u.TempleName,
                                u.GodName,
                                u.TempleImage,
                                s.CountryId,
                                c.CountryName,
                                u.StateId,
                                s.StateName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.StateId == StateId).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Get Temple List by CityId
        ///</summary>
        [HttpGet("{CityId}")]
        public ActionResult GetTempleListbyCityId(int CityId)
        {
            try
            {
                var list = (from u in _context.Temples
                            join c in _context.Countries on u.CountryId equals c.CountryId
                            join s in _context.States on u.StateId equals s.StateId
                            join e in _context.Cities on u.CityId equals e.CityId

                            select new
                            {
                                u.TempleId,
                                u.TempleName,
                                u.GodName,
                                u.TempleImage,
                                s.CountryId,
                                c.CountryName,
                                u.StateId,
                                s.StateName,
                                u.CityId,
                                e.CityName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.CityId == CityId).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }



        // [HttpGet("{CountryId}/{StateId}/{CityId}")]
        //[HttpGet]
        //public ActionResult GetTempleListbyCountryStateCityId(int CountryId, int StateId, int CityId)
        //{
        //    try
        //    {
        //        var list = (from u in _context.Temples
        //                    join c in _context.Countries on u.CountryId equals c.CountryId
        //                    join s in _context.States on u.StateId equals s.StateId
        //                    join e in _context.Cities on u.CityId equals e.CityId

        //                    select new
        //                    {
        //                        u.TempleId,
        //                        u.TempleName,
        //                        s.CountryId,
        //                        c.CountryName,
        //                        u.StateId,
        //                        s.StateName,
        //                        u.CityId,
        //                        e.CityName,
        //                        u.IsDeleted
        //                    }).Where(x => x.IsDeleted == false && x.CountryId == CountryId && x.StateId == StateId && x.CityId == CityId).ToList();

        //        int totalRecords = list.Count();

        //        return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}





        //[HttpGet("{CountryId?}/{StateId?}/{CityId?}")]

        [HttpGet]
        public ActionResult GetTempleListbyCountryStateCityId(int? CountryId = null, int? StateId = null, int? CityId = null)
        {
            try
            {
                var list = (from u in _context.Temples
                            join c in _context.Countries on u.CountryId equals c.CountryId
                            join s in _context.States on u.StateId equals s.StateId
                            join e in _context.Cities on u.CityId equals e.CityId
                            select new
                            {
                                u.TempleId,
                                u.TempleName,
                                u.GodName,
                                u.TempleImage,
                                s.CountryId,
                                c.CountryName,
                                u.StateId,
                                s.StateName,
                                u.CityId,
                                e.CityName,
                                u.IsDeleted
                            });

                if (CountryId != null)
                {
                    list = list.Where(x => x.CountryId == CountryId);
                }

                if (StateId != null)
                {
                    list = list.Where(x => x.StateId == StateId);
                }

                if (CityId != null)
                {
                    list = list.Where(x => x.CityId == CityId);
                }

                var filteredList = list.Where(x => !x.IsDeleted).ToList();
                int totalRecords = filteredList.Count();

                return Ok(new { data = filteredList, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }











    }
}
