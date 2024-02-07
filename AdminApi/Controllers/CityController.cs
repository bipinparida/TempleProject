using AdminApi.DTO.App.LocationDTO;
using AdminApi.Models;
using AdminApi.Models.App.Location;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CityController : Controller
    {

        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<City> _CityRepo;

        public CityController(IConfiguration config,
                                    AppDbContext context,
                                    ISqlRepository<City> cityRepo)
        {
            _config = config;
            _context = context;
            _CityRepo = cityRepo;
        }

        [HttpPost]
        public IActionResult CityCreate(CreateCityDTO createCityDTO)
        {
            var objcheck = _context.Cities.SingleOrDefault(opt => opt.CityName == createCityDTO.CityName && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    City city = new City();
                    city.CityName = createCityDTO.CityName;
                    city.StateId = createCityDTO.StateId;
                    city.CountryId = createCityDTO.CountryId;
                    city.CreatedBy = createCityDTO.CreatedBy;
                    city.CreatedOn = System.DateTime.Now;
                    var obj = _CityRepo.Insert(city);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate StateName..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });

            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetCityList()
        {
            try
            {
                var list = (from u in _context.Cities
                            join a in _context.States on u.StateId equals a.StateId
                            join c in _context.Countries on u.CountryId equals c.CountryId

                            select new
                            {
                                u.CityId,
                                u.CityName,
                                a.StateName,
                                a.StateId,
                                c.CountryId,
                                c.CountryName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false).Distinct().ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{CityId}")]
        public ActionResult GetSingleCity(int CityId)
        {
            try
            {
                var singleCity = _CityRepo.SelectById(CityId);
                return Ok(singleCity);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpPost]
        public ActionResult UpdateCity(UpdateCityDTO updateCityDTO)
        {
            try
            {
                var objCity = _context.Cities.SingleOrDefault(opt => opt.CityId == updateCityDTO.CityId);
                objCity.CityName = updateCityDTO.CityName;
                objCity.StateId = updateCityDTO.StateId;
                objCity.CountryId = updateCityDTO.CountryId;
                objCity.UpdatedBy = updateCityDTO.CreatedBy;
                objCity.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objCity);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteCity(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Cities.SingleOrDefault(opt => opt.CityId == Id);
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

        [HttpGet("{Stateid}")]
        public ActionResult GetCityListbystateid(int Stateid)
        {
            try
            {
                var list = (from u in _context.Cities
                            join a in _context.States on u.StateId equals a.StateId

                            select new
                            {
                                a.StateId,
                                a.StateName,
                                u.CityName,
                                u.CityId,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.StateId == Stateid).Distinct().ToList();

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
