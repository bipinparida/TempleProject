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


		//[HttpPost]
		//public IActionResult ProductCreate(ProductDTO productDTO)
		//{
		//	if (productDTO.file != null)
		//	{
		//		string filename = ContentDispositionHeaderValue.Parse(productDTO.file.ContentDisposition).FileName.Trim('"');
		//		filename = EnsureCorrectFilename(filename);

		//		string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
		//		string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
		//		string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
		//		productDTO.file.CopyTo(new FileStream(imagePath, FileMode.Create));
		//		string photopath = "/images/" + uniqueFileName;

		//		ProductNewDTO ag = new ProductNewDTO();

		//		ag.TempleId = productDTO.TempleId;
		//		ag.PanditId = productDTO.PanditId;
		//		ag.CategoryId = productDTO.CategoryId;
		//		ag.SubCategoryId = productDTO.SubCategoryId;
		//		ag.ProductName = productDTO.ProductName;
		//		ag.SalePrice = productDTO.SalePrice;
		//		ag.MRP = productDTO.MRP;
		//		ag.DiscountAmount = productDTO.DiscountAmount;
		//		ag.Description = productDTO.Description;


		//		ag.Thumbnail = photopath;

		//		ag.CreatedBy = productDTO.CreatedBy;

		//		var a = _product.ProductCreate(ag);

		//		return Ok(a);
		//	}
		//	else
		//	{
		//		ProductNewDTO ag = new ProductNewDTO();

		//		ag.TempleId = productDTO.TempleId;
		//		ag.PanditId = productDTO.PanditId;
		//		ag.CategoryId = productDTO.CategoryId;
		//		ag.SubCategoryId = productDTO.SubCategoryId;
		//		ag.ProductName = productDTO.ProductName;
		//		ag.SalePrice = productDTO.SalePrice;
		//		ag.MRP = productDTO.MRP;
		//		ag.DiscountAmount = productDTO.DiscountAmount;
		//		ag.Description = productDTO.Description;


		//		//ag.PanditImage = photopath;

		//		ag.CreatedBy = productDTO.CreatedBy;

		//		var a = _product.ProductCreate(ag);

		//		return Ok(a);
		//	}
		//}


		 [HttpPost]
        public IActionResult ProductCreate(ProductDTO productDTO)
        {
            string thumbnailPath = "";
            string imagePaths = "";

            if (productDTO.file != null)
            {
                string filename = Path.GetFileName(productDTO.file.FileName);
                filename = EnsureCorrectFilename(filename);

                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
                string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    productDTO.file.CopyTo(stream);
                }
                thumbnailPath = "/images/" + uniqueFileName;
            }

            if (productDTO.files != null && productDTO.files.Any())
            {
                foreach (var imageFile in productDTO.files)
                {
                    string filename = Path.GetFileName(imageFile.FileName);
                    filename = EnsureCorrectFilename(filename);

                    string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + filename;
                    string imagePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var stream = new FileStream(imagePath, FileMode.Create))
                    {
                        imageFile.CopyTo(stream);
                    }
                    imagePaths += "/images/" + uniqueFileName + ",";
                }

                // Remove the trailing comma
                imagePaths = imagePaths.TrimEnd(',');
            }

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

            ag.Thumbnail = thumbnailPath;
            ag.Image = imagePaths;

            //ag.Image.Add(imagePaths); // Assuming Image is List<string> in ProductNewDTO

            ag.CreatedBy = productDTO.CreatedBy;

            var a = _product.ProductCreate(ag);

            return Ok(a);
        }



		private string EnsureCorrectFilename(string filename)
		{
			if (filename.Contains("\\"))
				filename = filename.Substring(filename.LastIndexOf("\\") + 1);

			return filename;
		}

	}
}
