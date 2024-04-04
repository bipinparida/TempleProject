using AdminApi.Models.App.Location;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Checkouts;
using AdminApi.DTO.App.LocationDTO;
using AdminApi.Models.Helper;
using System.Linq;
using System;
using AdminApi.DTO.App.CheckoutDTO;
using Microsoft.EntityFrameworkCore;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CheckoutController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Checkout> _CheckoutRepo;

        public CheckoutController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<Checkout> checkoutRepo)
        {
            _config = config;
            _context = context;
            _CheckoutRepo = checkoutRepo;
        }

        ///<summary>
        ///Create Checkout
        ///</summary>
        [HttpPost]
        public IActionResult CheckoutCreate(CreateCheckoutDTO createCheckoutDTO)
        {
            var objcheck = _context.Checkouts.SingleOrDefault(opt => opt.ProductId == createCheckoutDTO.ProductId && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    Checkout checkout = new Checkout();

                    checkout.ProductId = createCheckoutDTO.ProductId;
                    checkout.Quantity = createCheckoutDTO.Quantity;

                    checkout.CreatedBy = createCheckoutDTO.CreatedBy;
                    checkout.CreatedOn = System.DateTime.Now;
                    var obj = _CheckoutRepo.Insert(checkout);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    objcheck.Quantity += 1;
                    _context.SaveChanges();
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
        ///Update Checkout
        ///</summary>
        [HttpPost]
        public ActionResult UpdateCheckout(UpdateCheckoutDTO updateCheckoutDTO)
        {
            try
            {
                var objCheckout = _context.Checkouts.SingleOrDefault(opt => opt.CheckoutId == updateCheckoutDTO.CheckoutId);

                var existingCheckout = _context.Checkouts.SingleOrDefault(opt => opt.ProductId == updateCheckoutDTO.ProductId && opt.CheckoutId != updateCheckoutDTO.CheckoutId && opt.IsDeleted == false);

                if (existingCheckout != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate ProductName..!" });
                }

                objCheckout.ProductId = updateCheckoutDTO.ProductId;
                objCheckout.Quantity = updateCheckoutDTO.Quantity;
                objCheckout.UpdatedBy = updateCheckoutDTO.UpdatedBy;
                objCheckout.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objCheckout);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Get Checkout List
        ///</summary>
        [HttpGet]
        public ActionResult GetCheckoutList()
        {
            try
            {
                var list = (from u in _context.Checkouts
                            join c in _context.Products on u.ProductId equals c.ProductId

                            select new
                            {
                                u.ProductId,
                                u.Quantity,
                                c.ProductName,
                                c.CategoryId,
                                c.SubCategoryId,
                                c.SalePrice,
                                c.MRP,
                                c.DiscountAmount,
                                c.Description,
                                u.CreatedBy,
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
        ///Get Single Checkout by ID
        ///</summary>
        [HttpGet("{CheckoutId}")]
        public ActionResult GetSingleCheckout(int CheckoutId)
        {
            try
            {
                var singleCheckout = _CheckoutRepo.SelectById(CheckoutId);
                return Ok(singleCheckout);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Delete Single Checkout by ID
        ///</summary>
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteCheckout(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Checkouts.SingleOrDefault(opt => opt.CheckoutId == Id);
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

        ///<summary>
        ///CheckoutPlusUpdate by CheckoutId and CreatedBy
        ///</summary>
        [HttpPost("{CheckoutId}/{CreatedBy}")]
        public ActionResult CheckoutPlusUpdate(int CheckoutId, int CreatedBy)
        {
            try
            {
                var objCheckout = _context.Checkouts.SingleOrDefault(opt => opt.CheckoutId == CheckoutId);
                if (objCheckout != null)
                {
                    objCheckout.Quantity += 1;
                    objCheckout.UpdatedBy = CreatedBy;
                    objCheckout.UpdatedOn = DateTime.Now;
                    _context.SaveChanges();
                    return Ok(objCheckout);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///CheckoutMinusUpdate by CheckoutId and CreatedBy
        ///</summary>
        [HttpPost("{CheckoutId}/{CreatedBy}")]
        public ActionResult CheckOutMinusUpdate(int CheckoutId, int CreatedBy)
        {
            try
            {
                var objCheckout = _context.Checkouts.SingleOrDefault(opt => opt.CheckoutId == CheckoutId);
                if (objCheckout != null)
                {
                    int minQuantity = 1;
                    if(objCheckout.Quantity > minQuantity)
                    {
                        objCheckout.Quantity = objCheckout.Quantity - 1;
                        objCheckout.UpdatedBy = CreatedBy;
                        objCheckout.UpdatedOn = DateTime.Now;
                        _context.SaveChanges();
                        return Ok(objCheckout);
                    }
                    else
                    {
                        return BadRequest("MinimumQuantityReached");
                    }
                }
                else
                {
                    return NotFound();
                }

            }
            catch(Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///CheckOutDeleteAfterOrder by ProductId , DeletedBy and CreatedBy
        ///</summary>
        [HttpGet("{ProductId}/{DeletedBy}/{CreatedBy}")]
        public ActionResult CheckOutDeleteAfterOrder(int ProductId,int DeletedBy, int CreatedBy)
        {
            var objCheckout = _context.Checkouts.SingleOrDefault(opt => opt.ProductId == ProductId && opt.IsDeleted == false && opt.CreatedBy == CreatedBy);
            if (objCheckout != null)
            {
                objCheckout.IsDeleted= true;
                objCheckout.UpdatedBy = DeletedBy;
                objCheckout.UpdatedOn = DateTime.Now;
                _context.SaveChanges();
                return Ok(objCheckout);
            }
            else
            {
                return NotFound();
            }
        }


        ///<summary>
        ///Get Checkout List by Createdby
        ///</summary>
        [HttpGet("{CreatedBy}")]
        public ActionResult GetCheckoutListbyCreatedBy(int CreatedBy)
        {
            try
            {
                var list = (from u in _context.Checkouts
                            join c in _context.Products on u.ProductId equals c.ProductId
                            where u.CreatedBy == CreatedBy && u.IsDeleted == false

                            select new
                            {
                                u.ProductId,
                                u.Quantity,
                                c.ProductName,
                                c.CategoryId,
                                c.SubCategoryId,
                                c.SalePrice,
                                c.MRP,
                                c.DiscountAmount,
                                c.Description,
                                c.Thumbnail,
                                u.CreatedBy,
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
    }
}
