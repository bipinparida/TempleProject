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

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PoojaCategoryController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<PoojaCategory> _PoojaCategoryRepo;

        public PoojaCategoryController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<PoojaCategory> poojaCategoryRepo)
        {
            _config = config;
            _context = context;
            _PoojaCategoryRepo = poojaCategoryRepo;
        }
        [HttpPost]
        public IActionResult PoojaCategoryCreate(CreatePoojaCategoryDTO createPoojaCategoryDTO)
        {
            var objcheck = _context.PoojaCategories.SingleOrDefault(opt => opt.PoojaCategoryName == createPoojaCategoryDTO.PoojaCategoryName && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    PoojaCategory poojaCategory = new PoojaCategory();

                    poojaCategory.PoojaCategoryName = createPoojaCategoryDTO.PoojaCategoryName;

                    poojaCategory.CreatedBy = createPoojaCategoryDTO.CreatedBy;
                    poojaCategory.CreatedOn = System.DateTime.Now;
                    var obj = _PoojaCategoryRepo.Insert(poojaCategory);
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


        [HttpPost]
        public ActionResult UpdatePoojaCategory(UpdatePoojaCategoryDTO updatePoojaCategoryDTO)
        {
            try
            {
                var objPoojaCategory = _context.PoojaCategories.SingleOrDefault(opt => opt.PoojaCategoryId == updatePoojaCategoryDTO.PoojaCategoryId);

                var existingPoojaCategory = _context.PoojaCategories.SingleOrDefault(opt => opt.PoojaCategoryName == updatePoojaCategoryDTO.PoojaCategoryName && opt.PoojaCategoryId != updatePoojaCategoryDTO.PoojaCategoryId && opt.IsDeleted == false);

                if (existingPoojaCategory != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate CountryName..!" });
                }

                objPoojaCategory.PoojaCategoryName = updatePoojaCategoryDTO.PoojaCategoryName;
                objPoojaCategory.UpdatedBy = updatePoojaCategoryDTO.CreatedBy;
                objPoojaCategory.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objPoojaCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet]
        public ActionResult GetPoojaCategoryList()
        {
            try
            {
                var list = (from u in _context.PoojaCategories

                            select new
                            {
                                u.PoojaCategoryName,
                                u.PoojaCategoryId,
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
    }
}
