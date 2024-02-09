using AdminClient.Model.Pandit;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using AdminClient.DTO;
using System.Net.Http.Headers;

namespace AdminClient.Controllers
{
    public class PanditMobileController : Controller
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly IPandit _pandit;
        public PanditMobileController(IWebHostEnvironment hostingEnvironment,
                                            IPandit pandit)
        {
            _hostingEnvironment = hostingEnvironment;
            _pandit = pandit;
        }

        [HttpPost]
        public IActionResult PanditCreate(PanditDTO panditDTO)
        {
            if (panditDTO.file != null)
            {
                string filename = ContentDispositionHeaderValue.Parse(panditDTO.file.ContentDisposition).FileName.Trim('"');
                filename = EnsureCorrectFilename(filename);

                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
                string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
                panditDTO.file.CopyTo(new FileStream(imagePath, FileMode.Create));
                string photopath = "/images/" + uniqueFileName;

                PanditNewDTO ag = new PanditNewDTO();

                ag.CountryId = panditDTO.CountryId;
                ag.StateId = panditDTO.StateId;
                ag.CityId = panditDTO.CityId;
                ag.Experiences = panditDTO.Experiences;
                ag.PujaCategory = panditDTO.PujaCategory;
                ag.Religion = panditDTO.Religion;
                ag.MotherTongue = panditDTO.MotherTongue;
                ag.Caste = panditDTO.Caste;
                ag.Gothram = panditDTO.Gothram;
                ag.AadharCard = panditDTO.AadharCard;
                ag.Qualification = panditDTO.Qualification;
                ag.TempleId = panditDTO.TempleId;
                ag.PanditName = panditDTO.PanditName;
                ag.Address = panditDTO.Address;
                ag.PrimaryPhone = panditDTO.PrimaryPhone;
                ag.AlternatePhone = panditDTO.AlternatePhone;
                ag.MailId = panditDTO.MailId;
                ag.DateOfBirth = panditDTO.DateOfBirth;
                ag.Password = panditDTO.Password;
                ag.Message = panditDTO.Message;
                ag.Reject = panditDTO.Reject;
                ag.IsApprove = panditDTO.IsApprove;

                ag.PanditImage = photopath;
                ag.CreatedBy = panditDTO.CreatedBy;

                var a = _pandit.PanditCreate(ag);

                return Ok(a);
            }
            else
            {
                PanditNewDTO ag = new PanditNewDTO();

                ag.CountryId = panditDTO.CountryId;
                ag.StateId = panditDTO.StateId;
                ag.CityId = panditDTO.CityId;
                ag.Experiences = panditDTO.Experiences;
                ag.PujaCategory = panditDTO.PujaCategory;
                ag.Religion = panditDTO.Religion;
                ag.MotherTongue = panditDTO.MotherTongue;
                ag.Caste = panditDTO.Caste;
                ag.Gothram = panditDTO.Gothram;
                ag.AadharCard = panditDTO.AadharCard;
                ag.Qualification = panditDTO.Qualification;
                ag.TempleId = panditDTO.TempleId;
                ag.PanditName = panditDTO.PanditName;
                ag.Address = panditDTO.Address;
                ag.PrimaryPhone = panditDTO.PrimaryPhone;
                ag.AlternatePhone = panditDTO.AlternatePhone;
                ag.MailId = panditDTO.MailId;
                ag.DateOfBirth = panditDTO.DateOfBirth;
                ag.Password = panditDTO.Password;
                ag.Message = panditDTO.Message;
                ag.Reject = panditDTO.Reject;
                ag.IsApprove = panditDTO.IsApprove;

                //ag.PanditImage = photopath;
                ag.CreatedBy = panditDTO.CreatedBy;

                var a = _pandit.PanditCreate(ag);

                return Ok(a);
            }
        }

        private string EnsureCorrectFilename(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);

            return filename;
        }
    }
}
