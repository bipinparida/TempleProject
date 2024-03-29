﻿using AdminApi.DTO.App.PoojaCategoryDTO;
using AdminApi.Models;
using AdminApi.Models.App.PoojaCategory;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using AdminApi.DTO.App.PanditDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PoojaCategoryMappingController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<PoojaCategoryMapping> _PoojaCategoryMappingRepo;
        public PoojaCategoryMappingController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<PoojaCategoryMapping> poojaCategoryMappinRepo)
        {
            _config = config;
            _context = context;
            _PoojaCategoryMappingRepo = poojaCategoryMappinRepo;
        }


        ///<summary>
        ///Create PoojaCategory Mapping
        ///</summary>
        [HttpPost]
        public IActionResult PoojaCategoryMappingCreate(CreatePoojaCategoryMappingDTO createPoojaCategoryMappingDTO)
        {
            //var objcheck = _context.PoojaCategoryMappings.SingleOrDefault(opt => opt.PoojaCategoryId == createPoojaCategoryMappingDTO.PoojaCategoryId && opt.TempleId == createPoojaCategoryMappingDTO.TempleId && opt.IsDeleted == false);
            var objcheck = _context.PoojaCategoryMappings.SingleOrDefault(opt => opt.TempleId == createPoojaCategoryMappingDTO.TempleId && opt.PanditId==createPoojaCategoryMappingDTO.PanditId && opt.PoojaCategoryId==createPoojaCategoryMappingDTO.PoojaCategoryId && opt.PoojaCategoryTypeId==createPoojaCategoryMappingDTO.PoojaCategoryTypeId && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    PoojaCategoryMapping poojaCategoryMapping = new PoojaCategoryMapping();

                    poojaCategoryMapping.TempleId = createPoojaCategoryMappingDTO.TempleId;
                    poojaCategoryMapping.PoojaCategoryTypeId = createPoojaCategoryMappingDTO.PoojaCategoryTypeId;
                    poojaCategoryMapping.PoojaCategoryId = createPoojaCategoryMappingDTO.PoojaCategoryId;
                    poojaCategoryMapping.PanditId = createPoojaCategoryMappingDTO.PanditId;

                    poojaCategoryMapping.CreatedBy = createPoojaCategoryMappingDTO.CreatedBy;
                    poojaCategoryMapping.CreatedOn = System.DateTime.Now;
                    var obj = _PoojaCategoryMappingRepo.Insert(poojaCategoryMapping);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate PoojaCategoryName..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }


        ///<summary>
        ///Create PoojaCategory Mapping For Flutter
        ///</summary>
        [HttpPost]
        public IActionResult PoojaCategortyMappingMobile(PoojaCategoryMappingMasterDTOs poojaCategoryMappingMasterDTO)
        {
            try
            {
                if (poojaCategoryMappingMasterDTO.PoojaCategoryMappings != null && poojaCategoryMappingMasterDTO.PoojaCategoryMappings.Any())
                {
                    foreach (var mappingDto in poojaCategoryMappingMasterDTO.PoojaCategoryMappings)
                    {
                        var objcheck = _context.PoojaCategoryMappings
                            .SingleOrDefault(opt => opt.TempleId == mappingDto.TempleId &&
                                                    opt.PanditId == mappingDto.PanditId &&
                                                    opt.PoojaCategoryTypeId == mappingDto.PoojaCategoryTypeId &&
                                                    opt.PoojaCategoryId == mappingDto.PoojaCategoryId &&
                                                    opt.IsDeleted == false);

                        if (objcheck == null)
                        {
                            PoojaCategoryMapping poojaCategoryMapping = new PoojaCategoryMapping
                            {
                                TempleId = mappingDto.TempleId,
                                PanditId = mappingDto.PanditId,
                                PoojaCategoryTypeId = mappingDto.PoojaCategoryTypeId,
                                PoojaCategoryId = mappingDto.PoojaCategoryId,
                                CreatedBy = mappingDto.CreatedBy
                            };

                            var obj = _PoojaCategoryMappingRepo.Insert(poojaCategoryMapping);
                            return Ok(obj);
                        }
                        else
                        {
                            return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "PoojaCategory..!" });
                        }
                    }
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "No mappings provided!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Update PoojaCategory Mapping
        ///</summary>
        [HttpPost]
        public ActionResult UpdatePoojaCategoryMapping(UpdatePoojaCategoryMappingDTO updatePoojaCategoryMappingDTO)
        {
            try
            {
                var objPoojaCategoryMapping = _context.PoojaCategoryMappings.SingleOrDefault(opt => opt.PoojaCategoryMappingId == updatePoojaCategoryMappingDTO.PoojaCategoryMappingId);
                //var existingPoojaCategoryMapping = _context.PoojaCategoryMappings.SingleOrDefault(opt => opt.PoojaCategoryId == updatePoojaCategoryMappingDTO.PoojaCategoryId && opt.TempleId != updatePoojaCategoryMappingDTO.TempleId && opt.PoojaCategoryMappingId != updatePoojaCategoryMappingDTO.PoojaCategoryMappingId && opt.IsDeleted == false);
                var existingPoojaCategoryMapping = _context.PoojaCategoryMappings.SingleOrDefault(opt => opt.PoojaCategoryId==updatePoojaCategoryMappingDTO.PoojaCategoryId && opt.PoojaCategoryMappingId != updatePoojaCategoryMappingDTO.PoojaCategoryMappingId && opt.IsDeleted == false);
                if (existingPoojaCategoryMapping != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Name..!" });
                }

                objPoojaCategoryMapping.TempleId = updatePoojaCategoryMappingDTO.TempleId;
                objPoojaCategoryMapping.PoojaCategoryTypeId = updatePoojaCategoryMappingDTO.PoojaCategoryTypeId;
                objPoojaCategoryMapping.PoojaCategoryId = updatePoojaCategoryMappingDTO.PoojaCategoryId;
                objPoojaCategoryMapping.PanditId = updatePoojaCategoryMappingDTO.PanditId;

                objPoojaCategoryMapping.UpdatedBy = updatePoojaCategoryMappingDTO.UpdatedBy;
                objPoojaCategoryMapping.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objPoojaCategoryMapping);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Get PoojaCategory Mapping List
        ///</summary>
        [HttpGet]
        public ActionResult GetPoojaCategoryMappingList()
        {
            try
            {
                var list = (from u in _context.PoojaCategoryMappings
                            join c in _context.Temples on u.TempleId equals c.TempleId
                            join d in _context.PoojaCategories on u.PoojaCategoryId equals d.PoojaCategoryId
                            join p in _context.PoojaCategoryTypes on u.PoojaCategoryTypeId equals p.PoojaCategoryTypeId
                            join v in _context.Pandits on u.PanditId equals v.PanditId

                            select new
                            {
                                u.PoojaCategoryMappingId,
                                u.TempleId,
                                u.PoojaCategoryId,
                                c.TempleName,
                                u.PoojaCategoryTypeId,
                                p.PoojaCategoryTypeName,
                                d.PoojaCategoryName,
                                u.PanditId,
                                v.PanditName,
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
        ///Get Single PoojaCategory Mappping by ID
        ///</summary>
        [HttpGet("{PoojaCategoryMappingId}")]
        public ActionResult GetSinglePoojaCategoryMapping(int PoojaCategoryMappingId)
        {
            try
            {
                var singlePoojaCategoryMapping = _PoojaCategoryMappingRepo.SelectById(PoojaCategoryMappingId);
                return Ok(singlePoojaCategoryMapping);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }



        ///<summary>
        ///Delete Single PoojaCategory Mapping by ID
        ///</summary>
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeletePoojaCategoryMapping(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.PoojaCategoryMappings.SingleOrDefault(opt => opt.PoojaCategoryMappingId == Id);
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
        ///Get PoojaCategory List by Temple ID
        ///</summary>
        [HttpGet("{TempleId}")]
        public ActionResult GetPoojaCategoryListbyTempleId(int TempleId)
        {
            try
            {
                var list = (from u in _context.PoojaCategoryMappings
                            join p in _context.PoojaCategories on u.PoojaCategoryId equals p.PoojaCategoryId
                            join t in _context.Temples on u.TempleId equals t.TempleId

                            select new
                            {
                                u.TempleId,
                                u.PoojaCategoryMappingId,
                                u.PoojaCategoryId,
                                p.PoojaCategoryName,
                                t.TempleName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.TempleId == TempleId).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }



        ///<summary>
        ///Get PoojaCategory List by Pandit ID
        ///</summary>
        [HttpGet("{PanditId}")]
        public ActionResult GetPoojaCategoryListbyPanditId(int PanditId)
        {
            try
            {
                var list = (from u in _context.PoojaCategoryMappings
                            join p in _context.PoojaCategories on u.PoojaCategoryId equals p.PoojaCategoryId
                            join t in _context.Temples on u.TempleId equals t.TempleId
                            join v in _context.Pandits on u.PanditId equals v.PanditId
                            join w in _context.PoojaCategoryTypes on u.PoojaCategoryTypeId equals w.PoojaCategoryTypeId

                            select new
                            {
                                v.PanditId,
                                v.PanditName,
                                u.TempleId,
                                u.PoojaCategoryMappingId,
                                u.PoojaCategoryId,
                                p.PoojaCategoryName,
                                t.TempleName,
                                u.PoojaCategoryTypeId,
                                w.PoojaCategoryTypeName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.PanditId == PanditId).ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }



        ///<summary>
        ///Get Pandit List by PoojaCategory ID
        ///</summary>
        [HttpGet("{PoojaCategoryId}")]
        public ActionResult GetPanditListbyPoojaCategoryId(int PoojaCategoryId)
        {
            try
            {
                var list = (from u in _context.PoojaCategoryMappings
                            join p in _context.PoojaCategories on u.PoojaCategoryId equals p.PoojaCategoryId
                            //join t in _context.Temples on u.TempleId equals t.TempleId
                            join v in _context.Pandits on u.PanditId equals v.PanditId

                            select new
                            {
                                v.PanditId,
                                v.PanditName,
                                u.TempleId,
                                u.PoojaCategoryMappingId,
                                u.PoojaCategoryId,
                                p.PoojaCategoryName,
                                //t.TempleName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.PoojaCategoryId == PoojaCategoryId).ToList();

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
