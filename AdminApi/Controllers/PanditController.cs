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
using AdminApi.Models.App.PoojaCategory;

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


        //[HttpPost]
        //public IActionResult PanditCreate(CreatePanditDTO createPanditDTO)
        //{
        //    var objcheck = _context.Pandits.SingleOrDefault(opt => opt.PrimaryPhone == createPanditDTO.PrimaryPhone && opt.IsDeleted == false);
        //    try
        //    {
        //        if (objcheck == null)
        //        {
        //            Pandit pandit = new Pandit();

        //            pandit.CountryId = createPanditDTO.CountryId;
        //            pandit.StateId = createPanditDTO.StateId;
        //            pandit.CityId = createPanditDTO.CityId;
        //            pandit.Experiences = createPanditDTO.Experiences;
        //            pandit.PujaCategory = createPanditDTO.PujaCategory;
        //            pandit.Religion = createPanditDTO.Religion;
        //            pandit.MotherTongue = createPanditDTO.MotherTongue;
        //            pandit.Caste = createPanditDTO.Caste;
        //            pandit.Gothram = createPanditDTO.Gothram;
        //            pandit.AadharCard = createPanditDTO.AadharCard;
        //            pandit.Qualification = createPanditDTO.Qualification;
        //            pandit.TempleId = createPanditDTO.TempleId;
        //            pandit.PanditName = createPanditDTO.PanditName;
        //            pandit.Address = createPanditDTO.Address;
        //            pandit.PrimaryPhone = createPanditDTO.PrimaryPhone;
        //            pandit.AlternatePhone = createPanditDTO.AlternatePhone;
        //            pandit.MailId = createPanditDTO.MailId;
        //            pandit.DateOfBirth = createPanditDTO.DateOfBirth;
        //            pandit.Password = createPanditDTO.Password;
        //            pandit.PanditImage = createPanditDTO.PanditImage;
        //            pandit.Message = createPanditDTO.Message;
        //            pandit.IsApprove = false;
        //            pandit.Reject = false;

        //            pandit.CreatedBy = createPanditDTO.CreatedBy;
        //            pandit.CreatedOn = System.DateTime.Now;
        //            var obj = _PanditRepo.Insert(pandit);
        //            return Ok(obj);
        //        }
        //        else if (objcheck != null)
        //        {
        //            return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Pandit Mobile Number..!" });
        //        }
        //        return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }

        //}



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

                    if (createPanditDTO.PoojaCategoryMappings != null)
                    {
                        foreach (var mappingDto in createPanditDTO.PoojaCategoryMappings)
                        {
                            PoojaCategoryMapping poojaCategoryMapping = new PoojaCategoryMapping();
                            poojaCategoryMapping.TempleId = obj.TempleId;
                            poojaCategoryMapping.PanditId = obj.PanditId;
                            poojaCategoryMapping.PoojaCategoryTypeId = mappingDto.PoojaCategoryTypeId;
                            poojaCategoryMapping.PoojaCategoryId = mappingDto.PoojaCategoryId;
                            poojaCategoryMapping.CreatedBy = mappingDto.CreatedBy;

                            _context.PoojaCategoryMappings.Add(poojaCategoryMapping);
                        }

                        _context.SaveChanges();
                    }


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
                            join p in _context.Temples on u.TempleId equals p.TempleId
                            join c in _context.Countries on u.CountryId equals c.CountryId
                            join s in _context.States on u.StateId equals s.StateId
                            join d in _context.Cities on u.CityId equals d.CityId

                            select new
                            {
                                u.PanditId,
                                u.TempleId,
                                p.TempleName,
                                u.CountryId,
                                c.CountryName,
                                u.StateId,
                                s.StateName,
                                u.CityId,
                                d.CityName,
                                u.Experiences,
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

                var existingPandit = _context.Pandits.SingleOrDefault(opt => opt.PrimaryPhone == updatePanditDTO.PrimaryPhone && opt.PanditId != updatePanditDTO.PanditId && opt.IsDeleted == false);

                if (existingPandit != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Pandit Mobile Number..!" });
                }

                objPandit.CountryId = updatePanditDTO.CountryId;
                objPandit.StateId = updatePanditDTO.StateId;
                objPandit.CityId = updatePanditDTO.CityId;
                objPandit.Experiences = updatePanditDTO.Experiences;
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
                //objPandit.IsApprove = updatePanditDTO.IsApprove;
                //objPandit.Reject = updatePanditDTO.Reject;
                //objPandit.IsApprove = false;
                //objPandit.Reject = false;

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



        [HttpGet("{Id}")]
        public ActionResult ApprovePandit(int Id)
        {
            try
            {
                var objabout = _context.Pandits.SingleOrDefault(opt => opt.PanditId == Id);

                objabout.IsApprove = true;
                objabout.Reject = false;

                _context.SaveChanges();
                return Ok(objabout);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{Id}")]
        public ActionResult RejectPandit(int Id)
        {
            try
            {
                var objabout = _context.Pandits.SingleOrDefault(opt => opt.PanditId == Id);

                objabout.IsApprove = false;
                objabout.Reject = true;

                _context.SaveChanges();
                return Ok(objabout);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }



        [HttpPost]
        public ActionResult MessagePandit(MessagePanditDTO messagePanditDTO)
        {
            try
            {
                var objPandit = _context.Pandits.SingleOrDefault(opt => opt.PanditId == messagePanditDTO.PanditId);

                objPandit.Message = messagePanditDTO.Message;
              
                _context.SaveChanges();
                return Ok(objPandit);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{TempleId}")]
        public ActionResult GetPanditListbyTempleId(int TempleId)
        {
            try
            {
                var list = (from u in _context.Pandits
                            join t in _context.Temples on u.TempleId equals t.TempleId

                            select new
                            {
                               u.PanditId,
                               u.PanditName,
                               u.PanditImage,
                               t.TempleId,
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
