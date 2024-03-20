using AdminApi.Models.App.Bhaktas;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Banner;
using AdminApi.DTO.App.BhaktaDTO;
using AdminApi.Models.Helper;
using System.Linq;
using System;
using AdminApi.DTO.App.BannerDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BannerController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Banner> _BannerRepo;

        public BannerController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<Banner> bannerRepo)
        {
            _config = config;
            _context = context;
            _BannerRepo = bannerRepo;
        }

        ///<summary>
        ///Create Banner
        ///</summary>
        [HttpPost]
        public IActionResult BannerCreate(CreateBannerDTO createBannerDTO)
        {
            var objcheck = _context.Banners.SingleOrDefault(opt => opt.BannerName == createBannerDTO.BannerName && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    Banner banner = new Banner();

                    banner.BannerName = createBannerDTO.BannerName;
                    banner.BannerImage = createBannerDTO.BannerImage;

                    banner.CreatedBy = createBannerDTO.CreatedBy;
                    banner.CreatedOn = System.DateTime.Now;
                    var obj = _BannerRepo.Insert(banner);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate BannerName..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        ///<summary>
        ///Update Banner
        ///</summary>
        [HttpPost]
        public ActionResult UpdateBanner(UpdateBannerDTO updateBannerDTO)
        {
            try
            {
                var objBanner = _context.Banners.SingleOrDefault(opt => opt.BannerId == updateBannerDTO.BannerId);

                var existingBanner = _context.Banners.SingleOrDefault(opt => opt.BannerName == updateBannerDTO.BannerName && opt.BannerId != updateBannerDTO.BannerId && opt.IsDeleted == false);

                if (existingBanner != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate BannerName..!" });
                }

                objBanner.BannerName = updateBannerDTO.BannerName;
                objBanner.BannerImage = updateBannerDTO.BannerImage;

                objBanner.UpdatedBy = updateBannerDTO.UpdatedBy;
                objBanner.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objBanner);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Get Banner List
        ///</summary>
        [HttpGet]
        public ActionResult GetBannerList()
        {
            try
            {
                var list = (from u in _context.Banners

                            select new
                            {
                                u.BannerId,
                                u.BannerName,
                                u.BannerImage,
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
        ///Get Single Banner by ID
        ///</summary>
        [HttpGet("{BannerId}")]
        public ActionResult GetSingleBanner(int BannerId)
        {
            try
            {
                var singleBanner = _BannerRepo.SelectById(BannerId);
                return Ok(singleBanner);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Delete Single Banner by ID
        ///</summary>
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteBanner(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Banners.SingleOrDefault(opt => opt.BannerId == Id);
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
