using AdminApi.Models.App.Booking;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.PoojaCategoryItems;
using AdminApi.Models.Helper;
using Microsoft.Extensions.Options;
using System;
using AdminApi.DTO.App.PoojaCategoryItemDTO;
using System.Linq;
using AdminApi.DTO.App.PanditDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PoojaCategoryItemController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<PoojaCategoryItem> _PoojaCategoryItemRepo;

        public PoojaCategoryItemController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<PoojaCategoryItem> poojaCategoryItemRepo)
        {
            _config = config;
            _context = context;
            _PoojaCategoryItemRepo = poojaCategoryItemRepo;
        }
        [HttpPost]
        public IActionResult PoojaCategoryItemCreate(PoojaCategoryItemMasterDTO poojaCategoryItemMasterDTO)
        {
            try
            {

                for (int i = 0; i < poojaCategoryItemMasterDTO.CreatePoojaCategoryItemDTOs.Count; i++)
                {
                    PoojaCategoryItem opt = new PoojaCategoryItem();
                    opt.PoojaCategoryId = poojaCategoryItemMasterDTO.CreatePoojaCategoryItemDTOs[i].PoojaCategoryId;
                    opt.ItemName = poojaCategoryItemMasterDTO.CreatePoojaCategoryItemDTOs[i].ItemName;
                    opt.ItemPrice = poojaCategoryItemMasterDTO.CreatePoojaCategoryItemDTOs[i].ItemPrice;
                    opt.CreatedBy = poojaCategoryItemMasterDTO.CreatePoojaCategoryItemDTOs[i].CreatedBy;
                    opt.CreatedOn = System.DateTime.Now;
                    _PoojaCategoryItemRepo.Insert(opt);
                }

                return Ok(poojaCategoryItemMasterDTO);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet]
        public ActionResult GetPoojaCategoryItemList()
        {
            try
            {
                var list = (from u in _context.PoojaCategoryItems
                            join p in _context.PoojaCategories on u.PoojaCategoryId equals p.PoojaCategoryId

                            select new
                            {
                                u.PoojaCategoryItemId,
                                u.PoojaCategoryId,
                                u.ItemName,
                                u.ItemPrice,
                                p.PoojaCategoryName,
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
        [HttpGet("{PoojaCategoryItemId}")]
        public ActionResult GetSinglePoojaCategoryItem(int PoojaCategoryItemId)
        {
            try
            {
                var singlepoojaCategoryItem = _PoojaCategoryItemRepo.SelectById(PoojaCategoryItemId);
                return Ok(singlepoojaCategoryItem);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpPost]
        public ActionResult UpdatePoojaCategoryItem(UpdatePoojaCategoryItemDTO updatePoojaCategoryItemDTO)
        {
            try
            {
                var objItems = _context.PoojaCategoryItems.SingleOrDefault(opt => opt.PoojaCategoryItemId == updatePoojaCategoryItemDTO.PoojaCategoryItemId);
                objItems.PoojaCategoryId = updatePoojaCategoryItemDTO.PoojaCategoryId;
                objItems.ItemName = updatePoojaCategoryItemDTO.ItemName;
                objItems.ItemPrice = updatePoojaCategoryItemDTO.ItemPrice;
                objItems.UpdatedBy = updatePoojaCategoryItemDTO.CreatedBy;
                objItems.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objItems);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeletePoojaCategoryItem(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.PoojaCategoryItems.SingleOrDefault(opt => opt.PoojaCategoryItemId == Id);
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
        //[HttpGet("{PoojaCategoryId}")]
        //public ActionResult GetPoojaCategoryItemListFromPoojacategoryId(int PoojacategoryId)
        //{
        //    try
        //    {
        //        var list = (from u in _context.PoojaCategoryItems
        //                    where u.PoojaCategoryId == PoojacategoryId
        //                    join p in _context.PoojaCategories on u.PoojaCategoryId equals p.PoojaCategoryId


        //                    select new
        //                    {
        //                        p.PoojaCategoryId,
        //                        p.PoojaCategoryName,
        //                        u.PoojaCategoryItemId,
        //                        u.ItemName,
        //                        u.ItemPrice,
        //                        u.IsDeleted
        //                    }).Where(x => x.IsDeleted == false).ToList();

        //        int totalRecords = list.Count();

        //        return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
        //    }

        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}
        //[HttpGet]
        //public ActionResult GetPoojacategoryItemListFromPoojacategoryId()
        //{
        //    try
        //    {
        //        var poojacategorys = (from p in _context.PoojaCategories
        //                         select new
        //                         {
        //                             p.PoojaCategoryId,
        //                             p.PoojaCategoryName
        //                         }).ToList();


        //        var poojacategoryitems = (from u in _context.PoojaCategoryItems
        //                       where u.IsDeleted == false
        //                       select new
        //                       {
        //                           u.PoojaCategoryId,
        //                           u.PoojaCategoryItemId,
        //                           u.ItemName,
        //                           u.ItemPrice,
        //                       }).ToList();


        //        var combinedList = poojacategorys.Select(q => new
        //        {
        //            PoojaCategoryId = q.PoojaCategoryId,
        //            PoojaCategoryName = q.PoojaCategoryName,
        //            Poojacategoryitems = poojacategoryitems.Where(o => o.PoojaCategoryId == q.PoojaCategoryId)
        //                              .Select(poojacategoryitem => new
        //                              {
        //                                  PoojaCategoryItemId = poojacategoryitem.PoojaCategoryItemId,
        //                                  PoojaCategoryId = poojacategoryitem.PoojaCategoryId,
        //                                  poojacategoryitem = poojacategoryitem.ItemName,
        //                                  poojacategoryitems = poojacategoryitem.ItemPrice,
        //                                  IsDeleted = poojacategoryitem.IsDeleted
        //                              }).ToList()
        //        }).ToList();

        //        int totalRecords = combinedList.Count();

        //        return Ok(new { data = combinedList, recordsTotal = totalRecords, recordsFiltered = totalRecords });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}
    }
}
