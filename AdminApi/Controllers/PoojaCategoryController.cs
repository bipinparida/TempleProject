using AdminApi.DTO.App.LocationDTO;
using AdminApi.Models;
using AdminApi.Models.App.Location;
using AdminApi.Models.App.PoojaCategory;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using AdminApi.DTO.App.PoojaCategoryDTO;
using AdminApi.DTO.App.PoojaCategoryItemDTO;
using AdminApi.Models.App.Temples;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PoojaCategoryController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<PoojaCategory> _PoojaCategoryRepo;
        private readonly ISqlRepository<Temple> _TempleRepo;

        public PoojaCategoryController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<PoojaCategory> poojaCategoryRepo,
                                 ISqlRepository<Temple> templeRepo
                                 )
        {
            _config = config;
            _context = context;
            _PoojaCategoryRepo = poojaCategoryRepo;
            _TempleRepo = templeRepo;
        }


        //[HttpPost]
        //public IActionResult PoojaCategoryCreate(CreatePoojaCategoryDTO createPoojaCategoryDTO)
        //{
        //    var objcheck = _context.PoojaCategories.SingleOrDefault(opt => opt.PoojaCategoryName == createPoojaCategoryDTO.PoojaCategoryName && opt.IsDeleted == false);
        //    try
        //    {
        //        if (objcheck == null)
        //        {
        //            PoojaCategory poojaCategory = new PoojaCategory();

        //            poojaCategory.TempleId = createPoojaCategoryDTO.TempleId;
        //            poojaCategory.PoojaCategoryTypeId = createPoojaCategoryDTO.PoojaCategoryTypeId;
        //            poojaCategory.PoojaCategoryName = createPoojaCategoryDTO.PoojaCategoryName;

        //            poojaCategory.CreatedBy = createPoojaCategoryDTO.CreatedBy;
        //            poojaCategory.CreatedOn = System.DateTime.Now;
        //            var obj = _PoojaCategoryRepo.Insert(poojaCategory);
        //            return Ok(obj);
        //        }
        //        else if (objcheck != null)
        //        {
        //            return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate PoojaCategoryName..!" });
        //        }
        //        return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }

        //}



        //[HttpPost]
        //public IActionResult PoojaCategoryCreate(PoojaCategoryMasterDTO poojaCategoryMasterDTO)
        //{

        //    try
        //    {
        //        for (int i = 0; i < poojaCategoryMasterDTO.CreatePoojaCategoryDTOs.Count; i++)
        //        {
        //            PoojaCategory opt = new PoojaCategory();
        //            opt.TempleId = poojaCategoryMasterDTO.CreatePoojaCategoryDTOs[i].TempleId;
        //            opt.PoojaCategoryTypeId = poojaCategoryMasterDTO.CreatePoojaCategoryDTOs[i].PoojaCategoryTypeId;
        //            opt.PoojaCategoryName = poojaCategoryMasterDTO.CreatePoojaCategoryDTOs[i].PoojaCategoryName;
        //            opt.CreatedBy = poojaCategoryMasterDTO.CreatePoojaCategoryDTOs[i].CreatedBy;
        //            opt.CreatedOn = System.DateTime.Now;
        //            _PoojaCategoryRepo.Insert(opt);
        //        }

        //        return Ok(poojaCategoryMasterDTO);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}



        //[HttpPost]
        //public IActionResult PoojaCategoryCreate(PoojaCategoryMasterDTO poojaCategoryMasterDTO)
        //{
        //    try
        //    {
        //        var existingCategoryNames = _PoojaCategoryRepo.SelectAll().Select(item => item.PoojaCategoryName).ToList();

        //        foreach (var itemDTO in poojaCategoryMasterDTO.CreatePoojaCategoryDTOs)
        //        {
        //            if (existingCategoryNames.Contains(itemDTO.PoojaCategoryName))
        //            {
        //                return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = $"Pooja Category with name '{itemDTO.PoojaCategoryName}' already exists!." });
        //            }

        //            PoojaCategory newItem = new PoojaCategory
        //            {
        //                TempleId = itemDTO.TempleId,
        //                PoojaCategoryTypeId = itemDTO.PoojaCategoryTypeId,
        //                PoojaCategoryName = itemDTO.PoojaCategoryName,
        //                CreatedBy = itemDTO.CreatedBy,
        //                CreatedOn = DateTime.Now
        //            };

        //            _PoojaCategoryRepo.Insert(newItem);

        //            existingCategoryNames.Add(itemDTO.PoojaCategoryName);
        //        }

        //        return Ok(poojaCategoryMasterDTO);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}



        ///<summary>
        ///Create PoojaCategory
        ///</summary>
        [HttpPost]
        public IActionResult PoojaCategoryCreate(PoojaCategoryMasterDTO poojaCategoryMasterDTO)
        {
            try
            {
                var existingCategoryNames = _PoojaCategoryRepo.SelectAll().Select(item => new { item.PoojaCategoryName, item.TempleId }).ToList();

                foreach (var itemDTO in poojaCategoryMasterDTO.CreatePoojaCategoryDTOs)
                {
                    if (existingCategoryNames.Any(x => x.PoojaCategoryName == itemDTO.PoojaCategoryName && x.TempleId == itemDTO.TempleId))
                    {
                        var temple = _TempleRepo.SelectById(itemDTO.TempleId); // Assuming you have a service method to retrieve temple name by ID
                        var templeName = temple != null ? temple.TempleName : "Unknown";

                        return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = $"Pooja Category with name '{itemDTO.PoojaCategoryName}' for Temple Name '{templeName}' already exists!" });
                    }

                    PoojaCategory newItem = new PoojaCategory
                    {
                        TempleId = itemDTO.TempleId,
                        PoojaCategoryTypeId = itemDTO.PoojaCategoryTypeId,
                        PoojaCategoryName = itemDTO.PoojaCategoryName,
                        PoojaPrice=itemDTO.PoojaPrice,
                        CreatedBy = itemDTO.CreatedBy,
                        CreatedOn = DateTime.Now
                    };

                    _PoojaCategoryRepo.Insert(newItem);

                    existingCategoryNames.Add(new { itemDTO.PoojaCategoryName, itemDTO.TempleId });
                }

                return Ok(poojaCategoryMasterDTO);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }



        ///<summary>
        ///Update PoojaCategory
        ///</summary>
        [HttpPost]
        public ActionResult UpdatePoojaCategory(UpdatePoojaCategoryDTO updatePoojaCategoryDTO)
        {
            try
            {
                var objPoojaCategory = _context.PoojaCategories.SingleOrDefault(opt => opt.PoojaCategoryId == updatePoojaCategoryDTO.PoojaCategoryId);

                var existingPoojaCategory = _context.PoojaCategories.SingleOrDefault(opt => opt.PoojaCategoryName == updatePoojaCategoryDTO.PoojaCategoryName && opt.PoojaCategoryId != updatePoojaCategoryDTO.PoojaCategoryId && opt.IsDeleted == false);

                if (existingPoojaCategory != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate PoojaCategoryName..!" });
                }

                objPoojaCategory.TempleId = updatePoojaCategoryDTO.TempleId;
                objPoojaCategory.PoojaCategoryTypeId = updatePoojaCategoryDTO.PoojaCategoryTypeId;
                objPoojaCategory.PoojaCategoryName = updatePoojaCategoryDTO.PoojaCategoryName;
                objPoojaCategory.PoojaPrice = updatePoojaCategoryDTO.PoojaPrice;
                objPoojaCategory.UpdatedBy = updatePoojaCategoryDTO.UpdatedBy;
                objPoojaCategory.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objPoojaCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Get PoojaCategory List
        ///</summary>
        [HttpGet]
        public ActionResult GetPoojaCategoryList()
        {
            try
            {
                var list = (from u in _context.PoojaCategories
                            join p in _context.PoojaCategoryTypes on u.PoojaCategoryTypeId equals p.PoojaCategoryTypeId
                            join t in _context.Temples on u.TempleId equals t.TempleId

                            select new
                            {
                                u.PoojaCategoryId,
                                u.PoojaCategoryName,
                                u.PoojaCategoryTypeId,
                                u.PoojaPrice,
                                u.TempleId,
                                t.TempleName,
                                p.PoojaCategoryTypeName,
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
        ///Get Single PoojaCategory by ID
        ///</summary>
        [HttpGet("{PoojaCategoryId}")]
        public ActionResult GetSinglePoojaCategory(int PoojaCategoryId)
        {
            try
            {
                var singleCountry = _PoojaCategoryRepo.SelectById(PoojaCategoryId);
                return Ok(singleCountry);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Delete Single PoojaCategory by ID
        ///</summary>
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeletePoojaCategory(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.PoojaCategories.SingleOrDefault(opt => opt.PoojaCategoryId == Id);
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
        ///Get PoojaCategory Type by Temple ID 
        ///</summary>
        [HttpGet("{TempleId}")]
        public ActionResult GetPoojaCategoryTypeListbyTempleId(int TempleId)
        {
            try
            {
                var list = (from u in _context.PoojaCategories
                            join p in _context.PoojaCategoryTypes on u.PoojaCategoryTypeId equals p.PoojaCategoryTypeId

                            select new
                            {
                                u.TempleId,
                                u.PoojaCategoryTypeId,
                                p.PoojaCategoryTypeName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.TempleId == TempleId).Distinct().ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Get PoojaCategory List by TempleId and PoojaCategoryId
        ///</summary>
        [HttpGet("{TempleId}/{PoojaCategoryTypeId}")]
        public ActionResult GetPoojaCategoryListbyTempleAndPoojaCategoryTypeId(int TempleId, int PoojaCategoryTypeId)
        {
            try
            {
                var list = (from u in _context.PoojaCategories

                            select new
                            {
                                u.TempleId,
                                u.PoojaCategoryTypeId,
                                u.PoojaCategoryId,
                                u.PoojaCategoryName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.PoojaCategoryTypeId == PoojaCategoryTypeId && x.TempleId == TempleId).Distinct().ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        //[HttpGet("{PoojaCategoryTypeId}")]
        //public ActionResult GetPoojaCategoryListbyPoojaCategoryTypeId(int PoojaCategoryTypeId)
        //{
        //    try
        //    {
        //        var list = (from u in _context.PoojaCategories

        //                    select new
        //                    {
        //                        u.PoojaCategoryTypeId,
        //                        u.PoojaCategoryId,
        //                        u.PoojaCategoryName,
        //                        u.IsDeleted
        //                    }).Where(x => x.IsDeleted == false && x.PoojaCategoryTypeId == PoojaCategoryTypeId).Distinct().ToList();

        //        int totalRecords = list.Count();

        //        return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}





    }
}
