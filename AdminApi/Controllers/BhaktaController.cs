using AdminApi.DTO.App.TempleDTO;
using AdminApi.Models;
using AdminApi.Models.App.Bhaktas;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using AdminApi.DTO.App.BhaktaDTO;
using AdminApi.DTO.App.LocationDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BhaktaController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Bhakta> _BhaktaRepo;

        public BhaktaController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<Bhakta> bhaktaRepo)
        {
            _config = config;
            _context = context;
            _BhaktaRepo = bhaktaRepo;
        }

        ///<summary>
        ///Create Bhakta
        ///</summary>
        [HttpPost]
        public IActionResult BhaktaCreate(CreateBhaktaDTO createBhaktaDTO)
        {
            var objcheck = _context.Bhaktas.SingleOrDefault(opt => opt.PrimaryPhone == createBhaktaDTO.PrimaryPhone && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    Bhakta bhakta = new Bhakta();

                    bhakta.BhaktaName = createBhaktaDTO.BhaktaName;
                    bhakta.Address = createBhaktaDTO.Address;
                    bhakta.PrimaryPhone = createBhaktaDTO.PrimaryPhone;
                    bhakta.AlternatePhone = createBhaktaDTO.AlternatePhone;
                    bhakta.MailId = createBhaktaDTO.MailId;
                    bhakta.DateOfBirth = createBhaktaDTO.DateOfBirth;
                    bhakta.Password = createBhaktaDTO.Password;
                    bhakta.BhaktaImage = createBhaktaDTO.BhaktaImage;

                    bhakta.CreatedBy = createBhaktaDTO.CreatedBy;
                    bhakta.CreatedOn = System.DateTime.Now;
                    var obj = _BhaktaRepo.Insert(bhakta);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Mobile Number..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }


        ///<summary>
        ///Get Bhakta List
        ///</summary>
        [HttpGet]
        public ActionResult GetBhaktaList()
        {
            try
            {
                var list = (from u in _context.Bhaktas

                            select new
                            {
                                u.BhaktaId,
                                u.BhaktaName,
                                u.Address,
                                u.PrimaryPhone,
                                u.AlternatePhone,
                                u.MailId,
                                u.DateOfBirth,
                                u.Password,
                                u.BhaktaImage,
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
        ///Get Single Bhakta by ID
        ///</summary>
        [HttpGet("{BhaktaId}")]
        public ActionResult GetSingleBhakta(int BhaktaId)
        {
            try
            {
                var singleBhakta = _BhaktaRepo.SelectById(BhaktaId);
                return Ok(singleBhakta);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Update Bhakta
        ///</summary>
        [HttpPost]
        public ActionResult UpdateBhakta(UpdateBhaktaDTO updateBhaktaDTO)
        {
            try
            {
                var objBhakta = _context.Bhaktas.SingleOrDefault(opt => opt.BhaktaId == updateBhaktaDTO.BhaktaId);

                var existingBhakta = _context.Bhaktas.SingleOrDefault(opt => opt.PrimaryPhone == updateBhaktaDTO.PrimaryPhone && opt.BhaktaId != updateBhaktaDTO.BhaktaId && opt.IsDeleted == false);

                if (existingBhakta != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Primary Phone..!" });
                }

                objBhakta.BhaktaName = updateBhaktaDTO.BhaktaName;
                objBhakta.Address = updateBhaktaDTO.Address;
                objBhakta.PrimaryPhone = updateBhaktaDTO.PrimaryPhone;
                objBhakta.AlternatePhone = updateBhaktaDTO.AlternatePhone;
                objBhakta.MailId = updateBhaktaDTO.MailId;
                objBhakta.DateOfBirth = updateBhaktaDTO.DateOfBirth;
                objBhakta.Password = updateBhaktaDTO.Password;
                objBhakta.BhaktaImage = updateBhaktaDTO.BhaktaImage;

                objBhakta.UpdatedBy = updateBhaktaDTO.CreatedBy;
                objBhakta.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objBhakta);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Delete Single Bhakta by ID
        ///</summary>
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteBhakta(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Bhaktas.SingleOrDefault(opt => opt.BhaktaId == Id);
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
