﻿using AdminApi.Models;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using AdminApi.DTO.App.TempleDTO;
using AdminApi.Models.App.Temples;


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
                    temple.Latitude = createTempleDTO.Latitude;
                    temple.Longitude = createTempleDTO.Longitude;
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


        [HttpGet]
        public ActionResult GetTempleList()
        {
            try
            {
                var list = (from u in _context.Temples

                            select new
                            {
                                u.TempleId,
                                u.TempleName,
                                u.CountryId,
                                u.StateId,
                                u.CityId,
                                u.Latitude,
                                u.Longitude,
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


        [HttpPost]
        public ActionResult UpdateTemple(UpdateTempleDTO updateTempleDTO)
        {
            try
            {
                var objTemple = _context.Temples.SingleOrDefault(opt => opt.TempleId == updateTempleDTO.TempleId);

                objTemple.TempleName = updateTempleDTO.TempleName;
                objTemple.CountryId = updateTempleDTO.CountryId;
                objTemple.StateId = updateTempleDTO.StateId;
                objTemple.CityId = updateTempleDTO.CityId;
                objTemple.Latitude = updateTempleDTO.Latitude;
                objTemple.Longitude = updateTempleDTO.Longitude;
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

    }
}
