using AdminApi.Models.App.Categories;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.DTO.App.CategoryDTO;
using AdminApi.Models.Helper;
using System.Linq;
using System;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SubCategoryController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<SubCategory> _SubCategoryRepo;

        public SubCategoryController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<SubCategory> subCategoryRepo)
        {
            _config = config;
            _context = context;
            _SubCategoryRepo = subCategoryRepo;
        }


        ///<summary>
        ///Create SubCategory
        ///</summary>
        [HttpPost]
        public IActionResult SubCategoryCreate(CreateSubCategoryDTO createSubCategoryDTO)
        {
            var objcheck = _context.SubCategorys.SingleOrDefault(opt => opt.SubCategoryName == createSubCategoryDTO.SubCategoryName && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    SubCategory subCategory = new SubCategory();
                    subCategory.CategoryId = createSubCategoryDTO.CategoryId;
                    subCategory.SubCategoryName = createSubCategoryDTO.SubCategoryName;
                    subCategory.SubCategoryImage = createSubCategoryDTO.SubCategoryImage;


                    subCategory.CreatedBy = createSubCategoryDTO.CreatedBy;
                    subCategory.CreatedOn = System.DateTime.Now;
                    var obj = _SubCategoryRepo.Insert(subCategory);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate SubCategoryName..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }


        ///<summary>
        ///Update SubCategory
        ///</summary>
        [HttpPost]
        public ActionResult UpdateSubCategory(UpdateSubCategoryDTO updateSubCategoryDTO)
        {
            try
            {
                var objSubCategory = _context.SubCategorys.SingleOrDefault(opt => opt.SubCategoryId == updateSubCategoryDTO.SubCategoryId);

                var existingSubCategory = _context.SubCategorys.SingleOrDefault(opt => opt.SubCategoryName == updateSubCategoryDTO.SubCategoryName && opt.SubCategoryId != updateSubCategoryDTO.SubCategoryId && opt.IsDeleted == false);

                if (existingSubCategory != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate CategoryName..!" });
                }

                objSubCategory.CategoryId=updateSubCategoryDTO.CategoryId;
                objSubCategory.SubCategoryName = updateSubCategoryDTO.SubCategoryName;
                objSubCategory.SubCategoryImage = updateSubCategoryDTO.SubCategoryImage;

                objSubCategory.UpdatedBy = updateSubCategoryDTO.UpdatedBy;
                objSubCategory.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objSubCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Get SubCategory List
        ///</summary>
        [HttpGet]
        public ActionResult GetSubCategoryList()
        {
            try
            {
                var list = (from u in _context.SubCategorys
                            join p in _context.Categories on u.CategoryId equals p.CategoryId

                            select new
                            {
                                u.CategoryId,
                                u.SubCategoryName,
                                u.SubCategoryImage,
                                u.SubCategoryId,
                                p.CategoryName,
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
        ///Get Single SubCategory by ID
        ///</summary>
        [HttpGet("{SubCategoryId}")]
        public ActionResult GetSingleSubCategory(int SubCategoryId)
        {
            try
            {
                var singleSubCategory = _SubCategoryRepo.SelectById(SubCategoryId);
                return Ok(singleSubCategory);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Delete Single SubCategory by ID
        ///</summary>
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteSubCategory(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.SubCategorys.SingleOrDefault(opt => opt.SubCategoryId == Id);
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
        ///Get SubCategory List by CategoryId
        ///</summary>
        [HttpGet("{CategoryId}")]
        public ActionResult GetSubCategoryListbyCategoryId(int CategoryId)
        {
            try
            {
                var list = (from u in _context.SubCategorys
                            join a in _context.Categories on u.CategoryId equals a.CategoryId

                            select new
                            {
                                u.SubCategoryId,
                                u.SubCategoryName,
                                u.SubCategoryImage,
                                a.CategoryName,
                                u.CategoryId,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.CategoryId == CategoryId).Distinct().ToList();

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
