using AdminApi.Models.App.Checkouts;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Orders;
using AdminApi.DTO.App.CheckoutDTO;
using AdminApi.Models.Helper;
using System.Linq;
using System;
using AdminApi.DTO.App.OrderDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderParentController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<OrderParent> _OrderParentRepo;
        private readonly ISqlRepository<Order> _OrderRepo;

        public OrderParentController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<OrderParent> orderParentRepo,
                                 IConfiguration configuration, ISqlRepository<Order> orderRepo)
        {
            _config = config;
            _context = context;
            _OrderParentRepo = orderParentRepo;
            _OrderRepo= orderRepo;
        }

        ///<summary>
        ///Create OrderParent
        ///</summary>
        [HttpPost]
        public IActionResult OrderParentCreate(CreateOrderParentDTO createOrderParentDTO)
        {
            
            try
            {
                    OrderParent orderParent = new OrderParent();

                    orderParent.BhaktaId = createOrderParentDTO.BhaktaId;
                    orderParent.TotalQuantity = createOrderParentDTO.TotalQuantity;
                    orderParent.TotalAmount = createOrderParentDTO.TotalAmount;

                    orderParent.CreatedBy = createOrderParentDTO.CreatedBy;
                    orderParent.CreatedOn = System.DateTime.Now;
                    var obj = _OrderParentRepo.Insert(orderParent);
                for(int i=0;i<createOrderParentDTO.CreateOrderDTOs.Count;i++)
                {
                    Order order = new Order();
                    order.OrderParentId = obj.OrderParentId;
                    order.ProductId = createOrderParentDTO.CreateOrderDTOs[i].ProductId;
                    order.Quantity = createOrderParentDTO.CreateOrderDTOs[i].Quantity;
                    order.Amount = createOrderParentDTO.CreateOrderDTOs[i].Amount;
                    order.CreatedBy = createOrderParentDTO.CreatedBy;
                    order.CreatedOn = System.DateTime.Now;

                    var orderobj = _OrderRepo.Insert(order);
                }
                    return Ok(createOrderParentDTO);
               
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        ///<summary>
        ///Update OrderParent
        ///</summary>
        [HttpPost]
        public ActionResult UpdateOrderParent(UpdateOrderParentDTO updateOrderParentDTO)
        {
            try
            {
                var objOrderParent = _context.OrderParents.SingleOrDefault(opt => opt.OrderParentId == updateOrderParentDTO.OrderParentId);
                if(objOrderParent != null)
                {
                    objOrderParent.BhaktaId = updateOrderParentDTO.BhaktaId;
                    objOrderParent.TotalQuantity = updateOrderParentDTO.TotalQuantity;
                    objOrderParent.TotalAmount = updateOrderParentDTO.TotalAmount;
                    objOrderParent.UpdatedBy = updateOrderParentDTO.UpdatedBy;
                    objOrderParent.UpdatedOn = System.DateTime.Now;
                    for(int i=0;i<updateOrderParentDTO.UpdateOrderDTOs.Count;i++)
                    {
                        Order order = new Order();
                        order.OrderParentId= updateOrderParentDTO.OrderParentId;
                        order.ProductId = updateOrderParentDTO.UpdateOrderDTOs[i].ProductId;
                        order.Quantity = updateOrderParentDTO.UpdateOrderDTOs[i].Quantity;
                        order.Amount = updateOrderParentDTO.UpdateOrderDTOs[i].Amount;
                        order.CreatedBy = updateOrderParentDTO.UpdatedBy;
                        order.UpdatedOn = DateTime.Now;

                    }
                    _context.SaveChanges();
                    return Ok(updateOrderParentDTO);
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
        ///Get OrderParent List
        ///</summary>
        //[HttpGet]
        //public ActionResult GetAllOrderList()
        //{
        //    try
        //    {
        //        var list = (from u in _context.OrderParents
        //                    join c in _context.Bhaktas on u.BhaktaId equals c.BhaktaId
        //                    join d in _context.Orders on u.OrderParentId equals d.OrderParentId
        //                    join e in _context.Products on d.ProductId equals e.ProductId

        //                    select new
        //                    {
        //                        u.OrderParentId,
        //                        u.BhaktaId,
        //                        c.BhaktaName,
        //                        u.TotalQuantity,
        //                        u.TotalAmount,
        //                        u.IsDeleted,
        //                        d.ProductId,
        //                        e.ProductName,
        //                        d.Quantity,
        //                        d.Amount,
        //                    }).Where(x => x.IsDeleted == false).Distinct().ToList();

        //        int totalRecords = list.Count();

        //        return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}



        [HttpGet]
        public ActionResult GetAllOrderList()
        {
            try
            {
                var list = (from u in _context.OrderParents
                            join c in _context.Bhaktas on u.BhaktaId equals c.BhaktaId
                            select new
                            {
                                u.OrderParentId,
                                u.BhaktaId,
                                c.BhaktaName,
                                u.TotalQuantity,
                                u.TotalAmount,
                                u.IsDeleted,
                                Order=(from r in  _context.Orders
                                       join s in _context.Products on r.ProductId equals s.ProductId
                                       select new
                                       {
                                           r.OrderParentId,
                                           s.ProductName,
                                           r.Quantity,
                                           r.Amount,
                                       }).ToList()

                            }).Where(x => x.IsDeleted == false).Distinct().ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Get Single OrderParent by ID
        ///</summary>
        [HttpGet("{OrderParentId}")]
        public ActionResult GetSingleOrder(int OrderParentId)
        {
            try
            {
                var list = (from u in _context.OrderParents
                            join c in _context.Bhaktas on u.BhaktaId equals c.BhaktaId

                            select new
                            {
                                u.OrderParentId,
                                u.BhaktaId,
                                c.BhaktaName,
                                u.TotalQuantity,
                                u.TotalAmount,
                                u.IsDeleted,
                                Orders = _context.Orders
                                .Where(x => x.OrderParentId == u.OrderParentId)
                                .Select(x => new CreateOrderDTO
                                {
                                    OrderParentId = x.OrderParentId,
                                    ProductId = x.ProductId,
                                    Quantity = x.Quantity,
                                    Amount = x.Amount,
                                    CreatedBy = x.CreatedBy
                                }).ToList(),
                            }).Where(x => x.OrderParentId == OrderParentId && x.IsDeleted == false).Distinct().ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Delete Single OrderParent by ID
        ///</summary>
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteOrderParent(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.OrderParents.SingleOrDefault(opt => opt.OrderParentId == Id);
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

    }
}
