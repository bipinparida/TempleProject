using AdminApi.Models.App.Location;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Categories;
using AdminApi.DTO.App.LocationDTO;
using AdminApi.Models.Helper;
using System.Linq;
using System;
using AdminApi.DTO.App.CategoryDTO;
using AdminApi.DTO.App.BhaktaDTO;
using AdminApi.Models.App.Bhaktas;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Category> _CategoryRepo;

        public CategoryController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<Category> categoryRepo)
        {
            _config = config;
            _context = context;
            _CategoryRepo = categoryRepo;
        }

        ///<summary>
        ///Create Category
        ///</summary>
        [HttpPost]
        public IActionResult CategoryCreate(CreateCategoryDTO createCategoryDTO)
        {
            var objcheck = _context.Categories.SingleOrDefault(opt => opt.CategoryName == createCategoryDTO.CategoryName && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    Category category = new Category();
                    category.CategoryName = createCategoryDTO.CategoryName;
                    category.CategoryImage = createCategoryDTO.CategoryImage;


                    category.CreatedBy = createCategoryDTO.CreatedBy;
                    category.CreatedOn = System.DateTime.Now;
                    var obj = _CategoryRepo.Insert(category);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate CategoryName..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }


        ///<summary>
        ///Update Category
        ///</summary>
        [HttpPost]
        public ActionResult UpdateCategory(UpdateCategoryDTO updateCategoryDTO)
        {
            try
            {
                var objCategory = _context.Categories.SingleOrDefault(opt => opt.CategoryId == updateCategoryDTO.CategoryId);

                var existingCategory = _context.Categories.SingleOrDefault(opt => opt.CategoryName == updateCategoryDTO.CategoryName && opt.CategoryId != updateCategoryDTO.CategoryId && opt.IsDeleted == false);

                if (existingCategory != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate CategoryName..!" });
                }

                objCategory.CategoryName = updateCategoryDTO.CategoryName;
                objCategory.CategoryImage = updateCategoryDTO.CategoryImage;

                objCategory.UpdatedBy = updateCategoryDTO.UpdatedBy;
                objCategory.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Get Category List
        ///</summary>
        [HttpGet]
        public ActionResult GetCategoryList()
        {
            try
            {
                var list = (from u in _context.Categories

                            select new
                            {
                                u.CategoryName,
                                u.CategoryImage,
                                u.CategoryId,
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
        ///Get Single Category by ID
        ///</summary>
        [HttpGet("{CategoryId}")]
        public ActionResult GetSingleCategory(int CategoryId)
        {
            try
            {
                var singleCategory = _CategoryRepo.SelectById(CategoryId);
                return Ok(singleCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Delete Single Category by ID
        ///</summary>
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteCategory(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Categories.SingleOrDefault(opt => opt.CategoryId == Id);
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
