using AdminApi.Models.App.Location;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.PoojaCategory;
using AdminApi.DTO.App.LocationDTO;
using AdminApi.Models.Helper;
using System.Linq;
using System;
using AdminApi.DTO.App.PoojaCategoryDTO;

namespace AdminApi.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PoojaCategoryTypeController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<PoojaCategoryType> _PoojaCategoryTypeRepo;

        public PoojaCategoryTypeController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<PoojaCategoryType> poojaCategoryTypeRepo)
        {
            _config = config;
            _context = context;
            _PoojaCategoryTypeRepo = poojaCategoryTypeRepo;
        }



        ///<summary>
        ///Create Pooja Category Type
        ///</summary>
        [HttpPost]
        public IActionResult PoojaCategoryTypeCreate(CreatePoojaCategoryTypeDTO createPoojaCategoryTypeDTO)
        {
            var objcheck = _context.PoojaCategoryTypes.SingleOrDefault(opt => opt.PoojaCategoryTypeName == createPoojaCategoryTypeDTO.PoojaCategoryTypeName && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    PoojaCategoryType poojaCategoryType = new PoojaCategoryType();

                    poojaCategoryType.PoojaCategoryTypeName = createPoojaCategoryTypeDTO.PoojaCategoryTypeName;

                    poojaCategoryType.CreatedBy = createPoojaCategoryTypeDTO.CreatedBy;
                    poojaCategoryType.CreatedOn = System.DateTime.Now;
                    var obj = _PoojaCategoryTypeRepo.Insert(poojaCategoryType);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate PoojaCategoryType..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        ///<summary>
        ///Update Pooja Category Type
        ///</summary>
        [HttpPost]
        public ActionResult UpdatePoojaCategoryType(UpdatePoojaCategoryTypeDTO updatePoojaCategoryTypeDTO)
        {
            try
            {
                var objCategoryType = _context.PoojaCategoryTypes.SingleOrDefault(opt => opt.PoojaCategoryTypeId == updatePoojaCategoryTypeDTO.PoojaCategoryTypeId);

                var existingCategoryType = _context.PoojaCategoryTypes.SingleOrDefault(opt => opt.PoojaCategoryTypeName == updatePoojaCategoryTypeDTO.PoojaCategoryTypeName && opt.PoojaCategoryTypeId != updatePoojaCategoryTypeDTO.PoojaCategoryTypeId && opt.IsDeleted == false);

                if (existingCategoryType != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate PoojaCategoryType..!" });
                }

                objCategoryType.PoojaCategoryTypeName = updatePoojaCategoryTypeDTO.PoojaCategoryTypeName;
                objCategoryType.UpdatedBy = updatePoojaCategoryTypeDTO.UpdatedBy;
                objCategoryType.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objCategoryType);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Get Pooja Category Type List
        ///</summary>
        [HttpGet]
        public ActionResult GetPoojaCategoryTypeList()
        {
            try
            {
                var list = (from u in _context.PoojaCategoryTypes

                            select new
                            {
                                u.PoojaCategoryTypeId,
                                u.PoojaCategoryTypeName,
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
        ///Get Single Pooja Category Type by ID
        ///</summary>
        [HttpGet("{PoojaCategoryTypeId}")]
        public ActionResult GetSinglePoojaCategoryType(int PoojaCategoryTypeId)
        {
            try
            {
                var singlePoojaCategoryType = _PoojaCategoryTypeRepo.SelectById(PoojaCategoryTypeId);
                return Ok(singlePoojaCategoryType);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Delete Single Pooja Category Type by ID
        ///</summary>
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeletesinglePoojaCategoryType(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.PoojaCategoryTypes.SingleOrDefault(opt => opt.PoojaCategoryTypeId == Id);
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
