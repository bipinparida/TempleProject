using AdminApi.DTO.App.LocationDTO;
using AdminApi.Models;
using AdminApi.Models.App.Pandits;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using AdminApi.DTO.App.PanditDTO;
using AdminApi.DTO.App.BhaktaDTO;
using Pandit = AdminApi.Models.App.Pandits.Pandit;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PanditController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Pandit> _PanditRepo;

        public PanditController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<Pandit> panditRepo)
        {
            _config = config;
            _context = context;
            _PanditRepo = panditRepo;
        }


        [HttpPost]
        public IActionResult PanditCreate(CreatePanditDTO createPanditDTO)
        {
            var objcheck = _context.Pandits.SingleOrDefault(opt => opt.PrimaryPhone == createPanditDTO.PrimaryPhone && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    Pandit pandit = new Pandit();

                    pandit.CountryId = createPanditDTO.CountryId;
                    pandit.StateId = createPanditDTO.StateId;
                    pandit.CityId = createPanditDTO.CityId;
                    pandit.Experiences = createPanditDTO.Experiences;
                    pandit.PujaCategory = createPanditDTO.PujaCategory;
                    pandit.Religion = createPanditDTO.Religion;
                    pandit.MotherTongue = createPanditDTO.MotherTongue;
                    pandit.Caste = createPanditDTO.Caste;
                    pandit.Gothram = createPanditDTO.Gothram;
                    pandit.AadharCard = createPanditDTO.AadharCard;
                    pandit.Qualification = createPanditDTO.Qualification;
                    pandit.TempleId = createPanditDTO.TempleId;
                    pandit.PanditName = createPanditDTO.PanditName;
                    pandit.Address = createPanditDTO.Address;
                    pandit.PrimaryPhone = createPanditDTO.PrimaryPhone;
                    pandit.AlternatePhone = createPanditDTO.AlternatePhone;
                    pandit.MailId = createPanditDTO.MailId;
                    pandit.DateOfBirth = createPanditDTO.DateOfBirth;
                    pandit.Password = createPanditDTO.Password;
                    pandit.PanditImage = createPanditDTO.PanditImage;
                    pandit.Message = createPanditDTO.Message;
                    pandit.IsApprove = false;
                    pandit.Reject = false;

                    pandit.CreatedBy = createPanditDTO.CreatedBy;
                    pandit.CreatedOn = System.DateTime.Now;
                    var obj = _PanditRepo.Insert(pandit);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Pandit Mobile Number..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        [HttpGet]
        public ActionResult GetPanditList()
        {
            try
            {
                var list = (from u in _context.Pandits
                            join a in _context.Temples on u.TempleId equals a.TempleId

                            select new
                            {
                                u.PanditId,
                                a.TempleId,
                                a.TempleName,
                                u.CountryId,
                                u.StateId,
                                u.CityId,
                                u.Experiences,
                                u.PujaCategory,
                                u.Religion,
                                u.MotherTongue,
                                u.Caste,
                                u.Gothram,
                                u.AadharCard,
                                u.Qualification,
                                u.PanditName,
                                u.Address,
                                u.PrimaryPhone,
                                u.AlternatePhone,
                                u.MailId,
                                u.DateOfBirth,
                                u.Password,
                                u.Message,
                                u.IsApprove,
                                u.Reject,
                                u.PanditImage,
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


        [HttpGet("{PanditId}")]
        public ActionResult GetSinglePandit(int PanditId)
        {
            try
            {
                var singlePandit = _PanditRepo.SelectById(PanditId);
                return Ok(singlePandit);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpPost]
        public ActionResult UpdatePandit(UpdatePanditDTO updatePanditDTO)
        {
            try
            {
                var objPandit = _context.Pandits.SingleOrDefault(opt => opt.PanditId == updatePanditDTO.PanditId);

                objPandit.CountryId = updatePanditDTO.CountryId;
                objPandit.StateId = updatePanditDTO.StateId;
                objPandit.CityId = updatePanditDTO.CityId;
                objPandit.Experiences = updatePanditDTO.Experiences;
                objPandit.PujaCategory = updatePanditDTO.PujaCategory;
                objPandit.Religion = updatePanditDTO.Religion;
                objPandit.MotherTongue = updatePanditDTO.MotherTongue;
                objPandit.Caste = updatePanditDTO.Caste;
                objPandit.Gothram = updatePanditDTO.Gothram;
                objPandit.AadharCard = updatePanditDTO.AadharCard;
                objPandit.Qualification = updatePanditDTO.Qualification;
                objPandit.TempleId = updatePanditDTO.TempleId;
                objPandit.PanditName = updatePanditDTO.PanditName;
                objPandit.Address = updatePanditDTO.Address;
                objPandit.PrimaryPhone = updatePanditDTO.PrimaryPhone;
                objPandit.AlternatePhone = updatePanditDTO.AlternatePhone;
                objPandit.MailId = updatePanditDTO.MailId;
                objPandit.DateOfBirth = updatePanditDTO.DateOfBirth;
                objPandit.Password = updatePanditDTO.Password;
                objPandit.PanditImage = updatePanditDTO.PanditImage;
                objPandit.Message = updatePanditDTO.Message;
                objPandit.IsApprove = updatePanditDTO.IsApprove;
                objPandit.Reject = updatePanditDTO.Reject;

                objPandit.UpdatedBy = updatePanditDTO.CreatedBy;
                objPandit.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objPandit);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeletePandit(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Pandits.SingleOrDefault(opt => opt.PanditId == Id);
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
