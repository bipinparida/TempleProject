using AdminClient.DTO;
using AdminClient.Model.Product;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System;
using System.Net.Http.Headers;
using System.Linq;

namespace AdminClient.Controllers
{
	public class ProductMobileController : Controller
	{
		private readonly IWebHostEnvironment _hostingEnvironment;
		private readonly IProduct _product;
		public ProductMobileController(IWebHostEnvironment hostingEnvironment,
											IProduct product)
		{
			_hostingEnvironment = hostingEnvironment;
			_product = product;
		}


		[HttpPost]
		public IActionResult ProductCreate(ProductDTO productDTO)
		{
			if (productDTO.file != null)
			{
                string filename = ContentDispositionHeaderValue.Parse(productDTO.file.ContentDisposition).FileName.Trim('"');
                string filename1 = ContentDispositionHeaderValue.Parse(productDTO.file1.ContentDisposition).FileName.Trim('"');
                string filename2 = ContentDispositionHeaderValue.Parse(productDTO.file2.ContentDisposition).FileName.Trim('"');
                string filename3 = ContentDispositionHeaderValue.Parse(productDTO.file3.ContentDisposition).FileName.Trim('"');
                string filename4 = ContentDispositionHeaderValue.Parse(productDTO.file4.ContentDisposition).FileName.Trim('"');

                filename = EnsureCorrectFilename(filename);
                filename1 = EnsureCorrectFilename(filename1);
                filename2 = EnsureCorrectFilename(filename2);
                filename3 = EnsureCorrectFilename(filename3);
                filename4 = EnsureCorrectFilename(filename4);

                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");

                string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
                string uniqueFileName1 = Guid.NewGuid().ToString() + "_" + filename1;
                string uniqueFileName2 = Guid.NewGuid().ToString() + "_" + filename2;
                string uniqueFileName3 = Guid.NewGuid().ToString() + "_" + filename3;
                string uniqueFileName4 = Guid.NewGuid().ToString() + "_" + filename4;

                string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
                string imagePath1 = Path.Combine(uploadsFolder, uniqueFileName1);
                string imagePath2 = Path.Combine(uploadsFolder, uniqueFileName2);
                string imagePath3 = Path.Combine(uploadsFolder, uniqueFileName3);
                string imagePath4 = Path.Combine(uploadsFolder, uniqueFileName4);

                productDTO.file.CopyTo(new FileStream(imagePath, FileMode.Create));
                productDTO.file1.CopyTo(new FileStream(imagePath1, FileMode.Create));
                productDTO.file2.CopyTo(new FileStream(imagePath2, FileMode.Create));
                productDTO.file3.CopyTo(new FileStream(imagePath3, FileMode.Create));
                productDTO.file4.CopyTo(new FileStream(imagePath4, FileMode.Create));

                string photopath = "/images/" + uniqueFileName;
                string photopath1 = "/images/" + uniqueFileName1;
                string photopath2 = "/images/" + uniqueFileName2;
                string photopath3 = "/images/" + uniqueFileName3;
                string photopath4 = "/images/" + uniqueFileName4;

                ProductNewDTO ag = new ProductNewDTO();

				ag.TempleId = productDTO.TempleId;
				ag.PanditId = productDTO.PanditId;
				ag.CategoryId = productDTO.CategoryId;
				ag.SubCategoryId = productDTO.SubCategoryId;
				ag.ProductName = productDTO.ProductName;
				ag.SalePrice = productDTO.SalePrice;
				ag.MRP = productDTO.MRP;
				ag.DiscountAmount = productDTO.DiscountAmount;
				ag.Description = productDTO.Description;


				ag.Thumbnail = photopath;
				ag.Image1 = photopath1;
				ag.Image2 = photopath2;
				ag.Image3 = photopath3;
				ag.Image4 = photopath4;

				ag.CreatedBy = productDTO.CreatedBy;

				var a = _product.ProductCreate(ag);

				return Ok(a);
			}
			else
			{
				ProductNewDTO ag = new ProductNewDTO();

				ag.TempleId = productDTO.TempleId;
				ag.PanditId = productDTO.PanditId;
				ag.CategoryId = productDTO.CategoryId;
				ag.SubCategoryId = productDTO.SubCategoryId;
				ag.ProductName = productDTO.ProductName;
				ag.SalePrice = productDTO.SalePrice;
				ag.MRP = productDTO.MRP;
				ag.DiscountAmount = productDTO.DiscountAmount;
				ag.Description = productDTO.Description;


				ag.CreatedBy = productDTO.CreatedBy;

				var a = _product.ProductCreate(ag);

				return Ok(a);
			}
		}


		//[HttpPost]
  //      public IActionResult ProductCreate(ProductDTO productDTO)
  //      {
  //          string thumbnailPath = "";
  //          string imagePaths = "";

  //          if (productDTO.file != null)
  //          {
  //              string filename = Path.GetFileName(productDTO.file.FileName);
  //              filename = EnsureCorrectFilename(filename);

  //              string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
  //              string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
  //              string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
  //              using (var stream = new FileStream(imagePath, FileMode.Create))
  //              {
  //                  productDTO.file.CopyTo(stream);
  //              }
  //              thumbnailPath = "/images/" + uniqueFileName;
  //          }

  //          if (productDTO.files != null && productDTO.files.Any())
  //          {
  //              foreach (var imageFile in productDTO.files)
  //              {
  //                  string filename = Path.GetFileName(imageFile.FileName);
  //                  filename = EnsureCorrectFilename(filename);

  //                  string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
  //                  string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
  //                  string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
  //                  using (var stream = new FileStream(imagePath, FileMode.Create))
  //                  {
  //                      imageFile.CopyTo(stream);
  //                  }
  //                  imagePaths += "/images/" + uniqueFileName + ",";
  //              }

  //              // Remove the trailing comma
  //              imagePaths = imagePaths.TrimEnd(',');
  //          }

  //          ProductNewDTO ag = new ProductNewDTO();

  //          ag.TempleId = productDTO.TempleId;
  //          ag.PanditId = productDTO.PanditId;
  //          ag.CategoryId = productDTO.CategoryId;
  //          ag.SubCategoryId = productDTO.SubCategoryId;
  //          ag.ProductName = productDTO.ProductName;
  //          ag.SalePrice = productDTO.SalePrice;
  //          ag.MRP = productDTO.MRP;
  //          ag.DiscountAmount = productDTO.DiscountAmount;
  //          ag.Description = productDTO.Description;

  //          ag.Thumbnail = thumbnailPath;
  //          ag.Image = imagePaths;

  //          //ag.Image.Add(imagePaths); // Assuming Image is List<string> in ProductNewDTO

  //          ag.CreatedBy = productDTO.CreatedBy;

  //          var a = _product.ProductCreate(ag);

  //          return Ok(a);
  //      }



		private string EnsureCorrectFilename(string filename)
		{
			if (filename.Contains("\\"))
				filename = filename.Substring(filename.LastIndexOf("\\") + 1);

			return filename;
		}

	}
}
