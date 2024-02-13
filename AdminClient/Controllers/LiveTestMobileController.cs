using AdminClient.DTO;
using AdminClient.Model.Bhakta;
using AdminClient.Model.LiveTest;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Net.Http.Headers;

namespace AdminClient.Controllers
{
    public class LiveTestMobileController : Controller
    {

        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly ILiveTest _livetest;
        public LiveTestMobileController(IWebHostEnvironment hostingEnvironment,
                                            ILiveTest livetest)
        {
            _hostingEnvironment = hostingEnvironment;
            _livetest = livetest;
        }


        [HttpPost]
        public IActionResult LiveTestCreate(LiveTestDTO liveTestDTO)
        {
            if (liveTestDTO.file != null)
            {
                string filename = ContentDispositionHeaderValue.Parse(liveTestDTO.file.ContentDisposition).FileName.Trim('"');
                filename = EnsureCorrectFilename(filename);

                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
                string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
                liveTestDTO.file.CopyTo(new FileStream(imagePath, FileMode.Create));
                string photopath = "/images/" + uniqueFileName;

                LiveTestNewDTO ag = new LiveTestNewDTO();

                ag.PanditId = liveTestDTO.PanditId;
                ag.QuestionId = liveTestDTO.QuestionId;

                ag.LiveTestAnswer = photopath;
                ag.CreatedBy = liveTestDTO.CreatedBy;

                var a = _livetest.LiveTestCreate(ag);

                return Ok(a);
            }
            else
            {
                LiveTestNewDTO ag = new LiveTestNewDTO();

                ag.PanditId = liveTestDTO.PanditId;
                ag.QuestionId = liveTestDTO.QuestionId;

                //ag.LiveTestAnswer = photopath;
                ag.CreatedBy = liveTestDTO.CreatedBy;

                var a = _livetest.LiveTestCreate(ag);

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
