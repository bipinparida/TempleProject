using AdminApi.DTO.App.LocationDTO;
using AdminApi.Models;
using AdminApi.Models.App.Pandits;
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

    }
}
