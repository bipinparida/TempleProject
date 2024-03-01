﻿using AdminApi.Models.App.Location;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.DTO.App.LocationDTO;
using AdminApi.Models.Helper;
using System;
using System.Linq;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CountryController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Country> _CountryRepo;

        public CountryController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<Country> countryRepo)
        {
            _config = config;
            _context = context;
            _CountryRepo = countryRepo;
        }

        ///<summary>
        ///Create Country
        ///</summary>
        [HttpPost]
        public IActionResult CountryCreate(CreateCountryDTO countryDTO)
        {
            var objcheck = _context.Countries.SingleOrDefault(opt => opt.CountryName == countryDTO.CountryName && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    Country country = new Country();

                    country.CountryName = countryDTO.CountryName;
                    country.CountryCode = countryDTO.CountryCode;

                    country.CreatedBy = countryDTO.CreatedBy;
                    country.CreatedOn = System.DateTime.Now;
                    var obj = _CountryRepo.Insert(country);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate CountryName..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }


        ///<summary>
        ///Update Country
        ///</summary>
        [HttpPost]
        public ActionResult UpdateCountry(UpdateCountryDTO updateCountryDTO)
        {
            try
            {
                var objCountry = _context.Countries.SingleOrDefault(opt => opt.CountryId == updateCountryDTO.CountryId);

                var existingCountry = _context.Countries.SingleOrDefault(opt => opt.CountryName == updateCountryDTO.CountryName && opt.CountryId != updateCountryDTO.CountryId && opt.IsDeleted == false);

                if (existingCountry != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate CountryName..!" });
                }

                objCountry.CountryName = updateCountryDTO.CountryName;
                objCountry.CountryCode = updateCountryDTO.CountryCode;
                objCountry.UpdatedBy = updateCountryDTO.CreatedBy;
                objCountry.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objCountry);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Get Country List
        ///</summary>
        [HttpGet]
        public ActionResult GetCountryList()
        {
            try
            {
                var list = (from u in _context.Countries

                            select new
                            {
                                u.CountryName,
                                u.CountryId,
                                u.CountryCode,
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
        ///Get Single Country by ID
        ///</summary>
        [HttpGet("{CountryId}")]
        public ActionResult GetSingleCountry(int CountryId)
        {
            try
            {
                var singleCountry = _CountryRepo.SelectById(CountryId);
                return Ok(singleCountry);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Delete Single Country by ID
        ///</summary>
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteCountry(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Countries.SingleOrDefault(opt => opt.CountryId == Id);
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
