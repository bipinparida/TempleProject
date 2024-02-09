using AdminClient.DTO;
using AdminClient.Model.Bhakta;
using AdminClient.Model.Pandit;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Net.Http.Headers;

namespace AdminClient.Controllers
{
	public class BhaktaMobileController : Controller
	{
		private readonly IWebHostEnvironment _hostingEnvironment;
		private readonly IBhakta _bhakta;
		public BhaktaMobileController(IWebHostEnvironment hostingEnvironment,
											IBhakta bhakta)
		{
			_hostingEnvironment = hostingEnvironment;
			_bhakta = bhakta;
		}



		[HttpPost]
		public IActionResult BhaktaCreate(BhaktaDTO bhaktaDTO)
		{
			if (bhaktaDTO.file != null)
			{
				string filename = ContentDispositionHeaderValue.Parse(bhaktaDTO.file.ContentDisposition).FileName.Trim('"');
				filename = EnsureCorrectFilename(filename);

				string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
				string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
				string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
				bhaktaDTO.file.CopyTo(new FileStream(imagePath, FileMode.Create));
				string photopath = "/images/" + uniqueFileName;

				BhaktaNewDTO ag = new BhaktaNewDTO();

				ag.BhaktaName = bhaktaDTO.BhaktaName;
				ag.Address = bhaktaDTO.Address;
				ag.PrimaryPhone = bhaktaDTO.PrimaryPhone;
				ag.AlternatePhone = bhaktaDTO.AlternatePhone;
				ag.MailId = bhaktaDTO.MailId;
				ag.DateOfBirth = bhaktaDTO.DateOfBirth;
				ag.Password = bhaktaDTO.Password;
				

				ag.BhaktaImage = photopath;
				ag.CreatedBy = bhaktaDTO.CreatedBy;

				var a = _bhakta.BhaktaCreate(ag);

				return Ok(a);
			}
			else
			{
				BhaktaNewDTO ag = new BhaktaNewDTO();

				ag.BhaktaName = bhaktaDTO.BhaktaName;
				ag.Address = bhaktaDTO.Address;
				ag.PrimaryPhone = bhaktaDTO.PrimaryPhone;
				ag.AlternatePhone = bhaktaDTO.AlternatePhone;
				ag.MailId = bhaktaDTO.MailId;
				ag.DateOfBirth = bhaktaDTO.DateOfBirth;
				ag.Password = bhaktaDTO.Password;

				//ag.PanditImage = photopath;
				ag.CreatedBy = bhaktaDTO.CreatedBy;

				var a = _bhakta.BhaktaCreate(ag);

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
