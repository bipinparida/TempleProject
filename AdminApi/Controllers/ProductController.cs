﻿using AdminApi.Models.App.Feedbacks;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Products;
using AdminApi.DTO.App.FeedbackDTO;
using AdminApi.Models.Helper;
using System;
using AdminApi.DTO.App.ProductDTO;
using System.Linq;
using AdminApi.DTO.App.CategoryDTO;
using System.Collections.Generic;
using AdminApi.Models.App.Orders;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Product> _ProductRepo;

        public ProductController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<Product> productRepo)
        {
            _config = config;
            _context = context;
            _ProductRepo = productRepo;
        }

        ///<summary>
        ///Create Product
        ///</summary>
        [HttpPost]
        public IActionResult ProductCreate(CreateProductDTO createProductDTO)
        {
            var objcheck = _context.Products.SingleOrDefault(opt => opt.ProductName == createProductDTO.ProductName && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    Product product = new Product();

                    product.CategoryId = createProductDTO.CategoryId;
                    product.SubCategoryId = createProductDTO.SubCategoryId;
                    product.ProductName = createProductDTO.ProductName;
                    product.SalePrice = createProductDTO.SalePrice;
                    product.MRP = createProductDTO.MRP;
                    product.DiscountAmount = createProductDTO.DiscountAmount;
                    product.Thumbnail = createProductDTO.Thumbnail;

                    product.Image = createProductDTO.Image;
                    product.Image1 = createProductDTO.Image1;
                    product.Image2 = createProductDTO.Image2;
                    product.Image3 = createProductDTO.Image3;
                    product.Image4 = createProductDTO.Image4;

                    product.Description = createProductDTO.Description;

                    product.CreatedBy = createProductDTO.CreatedBy;
                    product.CreatedOn = System.DateTime.Now;
                    var obj = _ProductRepo.Insert(product);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate ProductName..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }


        ///<summary>
        ///Update Product
        ///</summary>
        [HttpPost]
        public ActionResult UpdateProduct(UpdateProductDTO updateProductDTO)
        {
            try
            {
                var objProduct = _context.Products.SingleOrDefault(opt => opt.ProductId == updateProductDTO.ProductId);
                //var existingProduct = _context.Products.SingleOrDefault(opt => opt.TempleId==updateProductDTO.TempleId && opt.PanditId==updateProductDTO.PanditId && opt.ProductName == updateProductDTO.ProductName && opt.ProductId != updateProductDTO.ProductId && opt.IsDeleted == false);
                var existingProduct = _context.Products.SingleOrDefault(opt => opt.ProductName == updateProductDTO.ProductName && opt.ProductId != updateProductDTO.ProductId && opt.IsDeleted == false);
                if (existingProduct != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate ProductName..!" });
                }

                objProduct.CategoryId = updateProductDTO.CategoryId;
                objProduct.SubCategoryId = updateProductDTO.SubCategoryId;
                objProduct.ProductName = updateProductDTO.ProductName;
                objProduct.SalePrice = updateProductDTO.SalePrice;
                objProduct.MRP = updateProductDTO.MRP;
                objProduct.DiscountAmount = updateProductDTO.DiscountAmount;
                objProduct.Thumbnail = updateProductDTO.Thumbnail;


                objProduct.Image = updateProductDTO.Image;
                objProduct.Image1 = updateProductDTO.Image1;
                objProduct.Image2 = updateProductDTO.Image2;
                objProduct.Image3 = updateProductDTO.Image3;
                objProduct.Image4 = updateProductDTO.Image4;
                objProduct.Description = updateProductDTO.Description;

                objProduct.UpdatedBy = updateProductDTO.UpdatedBy;
                objProduct.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objProduct);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Get Product List
        ///</summary>
        [HttpGet]
        public ActionResult GetProductList()
        {
            try
            {
                var list = (from u in _context.Products
                            join c in _context.Categories on u.CategoryId equals c.CategoryId
                            join f in _context.SubCategorys on u.SubCategoryId equals f.SubCategoryId

                            select new
                            {
                                u.ProductId,
                                u.CategoryId,
                                u.SubCategoryId,
                                u.ProductName,
                                u.SalePrice,
                                u.MRP,
                                u.DiscountAmount,
                                u.Thumbnail,
                                u.Image,
                                u.Image1,
                                u.Image2,
                                u.Image3,
                                u.Image4,
                                u.Description,
                                c.CategoryName,
                                f.SubCategoryName,
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
        ///Get Single Product by ID
        ///</summary>
        [HttpGet("{ProductId}")]
        public ActionResult GetSingleProduct(int ProductId)
        {
            try
            {
                var singleProduct = _ProductRepo.SelectById(ProductId);
                return Ok(singleProduct);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Delete Single Product by ID
        ///</summary>
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteProduct(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Products.SingleOrDefault(opt => opt.ProductId == Id);
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


        /////<summary>
        /////Gat Product List by Category ID
        /////</summary>

        //[HttpGet("{CategoryId}")]
        //public ActionResult GetProductListbyCategoryId(int CategoryId)
        //{
        //	try
        //	{
        //		var list = (from u in _context.Products
        //					join t in _context.Categories on u.CategoryId equals t.CategoryId

        //					select new
        //					{
        //						u.ProductId,
        //						u.TempleId,
        //						u.PanditId,
        //						u.CategoryId,
        //						u.SubCategoryId,
        //						u.ProductName,
        //						u.SalePrice,
        //						u.MRP,
        //						u.DiscountAmount,
        //						u.Thumbnail,
        //						u.Image,
        //						u.Description,
        //						t.CategoryName,
        //						u.IsDeleted
        //					}).ToList();

        //		var productsArrayImages = list.Select(item =>
        //			new
        //			{
        //				ProductId = item.ProductId,
        //				TempleId = item.TempleId,
        //				PanditId = item.PanditId,
        //				CategoryId = item.CategoryId,
        //				CategoryName = item.CategoryName,
        //				SubCategoryId = item.SubCategoryId,
        //				ProductName = item.ProductName,
        //				SalePrice = item.SalePrice,
        //				MRP = item.MRP,
        //				DiscountAmount = item.DiscountAmount,
        //				Description = item.Description,
        //				Thumbnail = item.Thumbnail,

        //				Image = item.Image?.Split(',').Select(image =>
        //				   new { Image = image.Trim() }) ?? Enumerable.Empty<object>(),

        //				IsDeleted = item.IsDeleted,

        //			}).Where(x => x.IsDeleted == false && x.CategoryId == CategoryId).ToList();

        //		int totalRecords = productsArrayImages.Count();

        //		return Ok(new { data = productsArrayImages, recordsTotal = totalRecords, recordsFiltered = totalRecords });
        //	}
        //	catch (Exception ex)
        //	{
        //		return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //	}
        //}


        ///<summary>
        ///Gat Product List by Category ID
        ///</summary>
        [HttpGet("{CategoryId}")]
        public ActionResult GetProductListbyCategoryId(int CategoryId)
        {
            try
            {
                var list = (from u in _context.Products
                            join t in _context.Categories on u.CategoryId equals t.CategoryId

                            select new
                            {
                                u.ProductId,
                                //u.TempleId,
                                //u.PanditId,
                                u.CategoryId,
                                u.SubCategoryId,
                                u.ProductName,
                                u.SalePrice,
                                u.MRP,
                                u.DiscountAmount,
                                u.Thumbnail,
                                u.Image,
                                u.Image1,
                                u.Image2,
                                u.Image3,
                                u.Image4,
                                u.Description,
                                t.CategoryName,
                                u.IsDeleted
                            }).ToList();

                var productsArrayImages = list.Select(item =>
                    new
                    {
                        ProductId = item.ProductId,
                        //TempleId = item.TempleId,
                        //PanditId = item.PanditId,
                        CategoryId = item.CategoryId,
                        CategoryName = item.CategoryName,
                        SubCategoryId = item.SubCategoryId,
                        ProductName = item.ProductName,
                        SalePrice = item.SalePrice,
                        MRP = item.MRP,
                        DiscountAmount = item.DiscountAmount,
                        Description = item.Description,
                        Thumbnail = item.Thumbnail,


                        Images = new List<string> { item.Image,item.Image1, item.Image2, item.Image3, item.Image4 }
    .Where(image => !string.IsNullOrEmpty(image))
    .Select(image => new { Image = image.Trim() })
    .ToList(),


                        IsDeleted = item.IsDeleted,

                    }).Where(x => x.IsDeleted == false && x.CategoryId == CategoryId).ToList();

                int totalRecords = productsArrayImages.Count();

                return Ok(new { data = productsArrayImages, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        /////<summary>
        /////Gat Product List by SubCategory ID
        /////</summary>

        //[HttpGet("{SubCategoryId}")]
        //public ActionResult GetProductListbySubCategoryId(int SubCategoryId)
        //{
        //	try
        //	{
        //		var list = (from u in _context.Products
        //					join t in _context.SubCategorys on u.SubCategoryId equals t.SubCategoryId

        //					select new
        //					{
        //						u.ProductId,
        //						u.TempleId,
        //						u.PanditId,
        //						u.CategoryId,
        //						u.SubCategoryId,
        //						u.ProductName,
        //						u.SalePrice,
        //						u.MRP,
        //						u.DiscountAmount,
        //						u.Thumbnail,
        //						u.Image,
        //						u.Description,
        //						t.SubCategoryName,
        //						u.IsDeleted
        //					}).ToList();

        //		var productsArrayImages = list.Select(item =>
        //			new
        //			{
        //				ProductId = item.ProductId,
        //				TempleId = item.TempleId,
        //				PanditId = item.PanditId,
        //				CategoryId = item.CategoryId,
        //				SubCategoryId = item.SubCategoryId,
        //				SubCategoryName = item.SubCategoryName,
        //				ProductName = item.ProductName,
        //				SalePrice = item.SalePrice,
        //				MRP = item.MRP,
        //				DiscountAmount = item.DiscountAmount,
        //				Description = item.Description,
        //				Thumbnail = item.Thumbnail,

        //				Image = item.Image?.Split(',').Select(image =>
        //				   new { Image = image.Trim() }) ?? Enumerable.Empty<object>(),

        //				IsDeleted = item.IsDeleted,

        //			}).Where(x => x.IsDeleted == false && x.SubCategoryId == SubCategoryId).ToList();

        //		int totalRecords = productsArrayImages.Count();

        //		return Ok(new { data = productsArrayImages, recordsTotal = totalRecords, recordsFiltered = totalRecords });
        //	}
        //	catch (Exception ex)
        //	{
        //		return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //	}
        //}



        ///<summary>
        ///Gat Product List by SubCategory ID
        ///</summary>
        [HttpGet("{SubCategoryId}")]
        public ActionResult GetProductListbySubCategoryId(int SubCategoryId)
        {
            try
            {
                var list = (from u in _context.Products
                            join t in _context.SubCategorys on u.SubCategoryId equals t.SubCategoryId

                            select new
                            {
                                u.ProductId,
                                //u.TempleId,
                                //u.PanditId,
                                u.CategoryId,
                                u.SubCategoryId,
                                u.ProductName,
                                u.SalePrice,
                                u.MRP,
                                u.DiscountAmount,
                                u.Thumbnail,
                                u.Image,
                                u.Image1,
                                u.Image2,
                                u.Image3,
                                u.Image4,
                                u.Description,
                                t.SubCategoryName,
                                u.IsDeleted
                            }).ToList();

                var productsArrayImages = list.Select(item =>
                    new
                    {
                        ProductId = item.ProductId,
                        //TempleId = item.TempleId,
                        //PanditId = item.PanditId,
                        CategoryId = item.CategoryId,
                        SubCategoryId = item.SubCategoryId,
                        SubCategoryName = item.SubCategoryName,
                        ProductName = item.ProductName,
                        SalePrice = item.SalePrice,
                        MRP = item.MRP,
                        DiscountAmount = item.DiscountAmount,
                        Description = item.Description,
                        Thumbnail = item.Thumbnail,

                        Images = new List<string> { item.Image, item.Image1, item.Image2, item.Image3, item.Image4 }
    .Where(image => !string.IsNullOrEmpty(image))
    .Select(image => new { Image = image.Trim() })
    .ToList(),

                        IsDeleted = item.IsDeleted,

                    }).Where(x => x.IsDeleted == false && x.SubCategoryId == SubCategoryId).ToList();

                int totalRecords = productsArrayImages.Count();

                return Ok(new { data = productsArrayImages, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


    }
}
