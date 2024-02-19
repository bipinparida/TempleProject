using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.PoojaCategory;
using AdminApi.DTO.App.FeedbackDTO;
using AdminApi.Models.App.Feedbacks;
using AdminApi.Models.Helper;
using System;
using AdminApi.DTO.App.PoojaCategoryDTO;
using System.Linq;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TemplePoojaCategoryController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<TemplePoojaCategory> _TemplePoojaCategoryRepo;
        public TemplePoojaCategoryController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<TemplePoojaCategory> templePoojaCategoryRepoRepo)
        {
            _config = config;
            _context = context;
            _TemplePoojaCategoryRepo = templePoojaCategoryRepoRepo;
        }
        [HttpPost]
        public IActionResult TemplePoojaCategoryCreate(CreateTemplePoojaCategoryDTO createTemplePoojaCategoryDTO)
        {
            var objcheck = _context.TemplePoojaCategories.SingleOrDefault(opt => opt.PoojaCategoryId == createTemplePoojaCategoryDTO.PoojaCategoryId && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    TemplePoojaCategory templePoojaCategory = new TemplePoojaCategory();

                    templePoojaCategory.TempleId = createTemplePoojaCategoryDTO.TempleId;
                    templePoojaCategory.PoojaCategoryId = createTemplePoojaCategoryDTO.PoojaCategoryId;

                    templePoojaCategory.CreatedBy = createTemplePoojaCategoryDTO.CreatedBy;
                    templePoojaCategory.CreatedOn = System.DateTime.Now;
                    var obj = _TemplePoojaCategoryRepo.Insert(templePoojaCategory);
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

        [HttpGet]
        public ActionResult GetTemplePoojaCategoryList()
        {
            try
            {
                var list = (from u in _context.TemplePoojaCategories
                            join c in _context.Temples on u.TempleId equals c.TempleId
                            join d in _context.PoojaCategories on u.PoojaCategoryId equals d.PoojaCategoryId

                            select new
                            {
                                u.TemplePoojaCategoryId,
                                u.TempleId,
                                u.PoojaCategoryId,
                                c.TempleName,
                                d.PoojaCategoryName,
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
        [HttpPost]
        public ActionResult UpdateTemplePoojaCategory(UpdateTemplePoojaCategoryDTO updateTemplePoojaCategoryDTO)
        {
            try
            {
                var objTemplePoojaCategory = _context.TemplePoojaCategories.SingleOrDefault(opt => opt.TemplePoojaCategoryId == updateTemplePoojaCategoryDTO.TemplePoojaCategoryId);


                objTemplePoojaCategory.TempleId = updateTemplePoojaCategoryDTO.TempleId;
                objTemplePoojaCategory.PoojaCategoryId = updateTemplePoojaCategoryDTO.PoojaCategoryId;

                objTemplePoojaCategory.UpdatedBy = updateTemplePoojaCategoryDTO.CreatedBy;
                objTemplePoojaCategory.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objTemplePoojaCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{TemplePoojaCategoryId}")]
        public ActionResult GetSingleTemplePoojaCategory(int TemplePoojaCategoryId)
        {
            try
            {
                var singleTemplePoojaCategory = _TemplePoojaCategoryRepo.SelectById(TemplePoojaCategoryId);
                return Ok(singleTemplePoojaCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteTemplePoojaCategory(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.TemplePoojaCategories.SingleOrDefault(opt => opt.TemplePoojaCategoryId == Id);
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
