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
using Microsoft.AspNetCore.Http;

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

        //[HttpPost]
        //public IActionResult PoojaCategoryItemCreate(PoojaCategoryItemMasterDTO poojaCategoryItemMasterDTO)
        //{
        //    try
        //    {

        //        for (int i = 0; i < poojaCategoryItemMasterDTO.CreatePoojaCategoryItemDTOs.Count; i++)
        //        {
        //            PoojaCategoryItem opt = new PoojaCategoryItem();
        //            opt.PoojaCategoryId = poojaCategoryItemMasterDTO.CreatePoojaCategoryItemDTOs[i].PoojaCategoryId;
        //            opt.ItemName = poojaCategoryItemMasterDTO.CreatePoojaCategoryItemDTOs[i].ItemName;
        //            opt.ItemPrice = poojaCategoryItemMasterDTO.CreatePoojaCategoryItemDTOs[i].ItemPrice;
        //            opt.CreatedBy = poojaCategoryItemMasterDTO.CreatePoojaCategoryItemDTOs[i].CreatedBy;
        //            opt.CreatedOn = System.DateTime.Now;
        //            _PoojaCategoryItemRepo.Insert(opt);
        //        }

        //        return Ok(poojaCategoryItemMasterDTO);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}



        //[HttpPost]
        //public IActionResult PoojaCategoryItemCreate(PoojaCategoryItemMasterDTO poojaCategoryItemMasterDTO)
        //{
        //    try
        //    {
        //        var existingItemNames = _PoojaCategoryItemRepo.SelectAll().Select(item => item.ItemName).ToList();

        //        foreach (var itemDTO in poojaCategoryItemMasterDTO.CreatePoojaCategoryItemDTOs)
        //        {
        //            if (existingItemNames.Contains(itemDTO.ItemName))
        //            {
        //                return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = $"Item with name '{itemDTO.ItemName}' already exists!." });
        //            }

        //            PoojaCategoryItem newItem = new PoojaCategoryItem
        //            {
        //                PoojaCategoryId = itemDTO.PoojaCategoryId,
        //                ItemName = itemDTO.ItemName,
        //                ItemPrice = itemDTO.ItemPrice,
        //                CreatedBy = itemDTO.CreatedBy,
        //                CreatedOn = DateTime.Now
        //            };

        //            _PoojaCategoryItemRepo.Insert(newItem);

        //            existingItemNames.Add(itemDTO.ItemName);
        //        }

        //        return Ok(poojaCategoryItemMasterDTO);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}



        //[HttpPost]
        //public IActionResult PoojaCategoryItemCreate(PoojaCategoryItemMasterDTO poojaCategoryItemMasterDTO)
        //{
        //    try
        //    {
        //        var existingItemNames = _PoojaCategoryItemRepo.SelectAll().ToDictionary(item => (item.PoojaCategoryId, item.ItemName));

        //        foreach (var itemDTO in poojaCategoryItemMasterDTO.CreatePoojaCategoryItemDTOs)
        //        {
        //            if (existingItemNames.ContainsKey((itemDTO.PoojaCategoryId, itemDTO.ItemName)))
        //            {
        //                return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = $"Item with name '{itemDTO.ItemName}' already exists in the category!" });
        //            }

        //            PoojaCategoryItem newItem = new PoojaCategoryItem
        //            {
        //                PoojaCategoryId = itemDTO.PoojaCategoryId,
        //                ItemName = itemDTO.ItemName,
        //                ItemPrice = itemDTO.ItemPrice,
        //                CreatedBy = itemDTO.CreatedBy,
        //                CreatedOn = DateTime.Now
        //            };

        //            _PoojaCategoryItemRepo.Insert(newItem);

        //            existingItemNames.Add((itemDTO.PoojaCategoryId, itemDTO.ItemName), newItem);
        //        }

        //        return Ok(poojaCategoryItemMasterDTO);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}



        ///<summary>
        ///Create PoojaCategory Item
        ///</summary>
        [HttpPost]
        public IActionResult PoojaCategoryItemCreate(PoojaCategoryItemMasterDTO poojaCategoryItemMasterDTO)
        {
            try
            {
                var existingItemNames = _PoojaCategoryItemRepo.SelectAll().ToDictionary(item => (item.PoojaCategoryId, item.ItemName));

                foreach (var itemDTO in poojaCategoryItemMasterDTO.CreatePoojaCategoryItemDTOs)
                {
                    // Update existingItemNames before duplicate check
                    if (existingItemNames.ContainsKey((itemDTO.PoojaCategoryId, itemDTO.ItemName)))
                    {
                        return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = $"Item with name '{itemDTO.ItemName}' already exists in the category!" });
                    }

                    PoojaCategoryItem newItem = new PoojaCategoryItem
                    {
                        TempleId = itemDTO.TempleId,
                        PoojaCategoryId = itemDTO.PoojaCategoryId,
                        ItemName = itemDTO.ItemName,
                        ItemPrice = itemDTO.ItemPrice,
                        CreatedBy = itemDTO.CreatedBy,
                        CreatedOn = DateTime.Now
                    };

                    _PoojaCategoryItemRepo.Insert(newItem);

                    // Update existingItemNames after inserting new item
                    existingItemNames.Add((itemDTO.PoojaCategoryId, itemDTO.ItemName), newItem);
                }

                return Ok(poojaCategoryItemMasterDTO);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Get PoojaCategory Item List
        ///</summary>
        [HttpGet]
        public ActionResult GetPoojaCategoryItemList()
        {
            try
            {
                var list = (from u in _context.PoojaCategoryItems
                            join a in _context.Temples on u.TempleId equals a.TempleId
                            join p in _context.PoojaCategories on u.PoojaCategoryId equals p.PoojaCategoryId

                            select new
                            {
                                u.PoojaCategoryItemId,
                                u.TempleId,
                                a.TempleName,
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


        ///<summary>
        ///Get Single PoojaCategory Item by ID
        ///</summary>
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

        ///<summary>
        ///Update PoojaCategory Item
        ///</summary>
        [HttpPost]
        public ActionResult UpdatePoojaCategoryItem(UpdatePoojaCategoryItemDTO updatePoojaCategoryItemDTO)
        {
            try
            {
                var objItems = _context.PoojaCategoryItems.SingleOrDefault(opt => opt.PoojaCategoryItemId == updatePoojaCategoryItemDTO.PoojaCategoryItemId);

                var existingPoojaCategory = _context.PoojaCategoryItems.SingleOrDefault(opt => opt.PoojaCategoryId == updatePoojaCategoryItemDTO.PoojaCategoryId && opt.ItemName == updatePoojaCategoryItemDTO.ItemName && opt.PoojaCategoryItemId != updatePoojaCategoryItemDTO.PoojaCategoryItemId && opt.IsDeleted == false);

                if (existingPoojaCategory != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate ItemName..!" });
                }
                objItems.PoojaCategoryId = updatePoojaCategoryItemDTO.PoojaCategoryId;
                objItems.TempleId = updatePoojaCategoryItemDTO.TempleId;
                objItems.ItemName = updatePoojaCategoryItemDTO.ItemName;
                objItems.ItemPrice = updatePoojaCategoryItemDTO.ItemPrice;
                objItems.UpdatedBy = updatePoojaCategoryItemDTO.UpdatedBy;
                objItems.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objItems);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Delete Single PoojaCategory Item by ID
        ///</summary>
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


        ///<summary>
        ///Get PoojaCategory Item List by PoojaCategoryId
        ///</summary>
        ///



        //[HttpGet("{PoojaCategoryId}")]
        //public ActionResult GetPoojaCategoryItemListByPoojacategoryId(int PoojaCategoryId)
        //{
        //    try
        //    {
        //        var list = (from u in _context.PoojaCategoryItems
        //                   // join q in _context.PoojaCategories on u.PoojaCategoryId equals q.PoojaCategoryId

        //                    select new
        //                    {
        //                        u.PoojaCategoryItemId,
        //                        u.PoojaCategoryId,
        //                        //q.PoojaCategoryName,
        //                        u.ItemName,
        //                        u.ItemPrice,

        //                        u.IsDeleted
        //                    }).Where(x => x.IsDeleted == false && x.PoojaCategoryId == PoojaCategoryId).ToList();

        //        int totalRecords = list.Count();

        //        return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}




        [HttpGet("{PoojaCategoryId}")]
        public ActionResult GetPoojaCategoryItemListByPoojacategoryId(int PoojaCategoryId)
        {
            try
            {
                var list = (from u in _context.PoojaCategoryItems

                            select new
                            {
                                u.TempleId,
                                u.PoojaCategoryItemId,
                                u.PoojaCategoryId,
                                u.ItemName,
                                u.ItemPrice,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.PoojaCategoryId == PoojaCategoryId).ToList();

                // Calculate total price by summing up all ItemPrices
                decimal totalPrice = (decimal)list.Sum(item => item.ItemPrice);

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords, totalItemPrice = totalPrice });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }



        ///<summary>
        ///Get PoojaCategoryItem List by TempleId and PoojaCategoryId
        ///</summary>
        [HttpGet("{TempleId}/{PoojaCategoryId}")]
        public ActionResult GetPoojaCategoryItemListbyTempleAndPoojaCategoryId(int TempleId, int PoojaCategoryId)
        {
            try
            {
                var list = (from u in _context.PoojaCategoryItems

                            select new
                            {
                                u.PoojaCategoryItemId,
                                u.PoojaCategoryId,
                                u.TempleId,
                                u.ItemName,
                                u.ItemPrice,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.PoojaCategoryId == PoojaCategoryId && x.TempleId == TempleId).Distinct().ToList();

                decimal totalPrice = (decimal)list.Sum(item => item.ItemPrice);

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords, totalItemPrice = totalPrice });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

    }
}
