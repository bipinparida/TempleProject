using AdminApi.data;
using AdminApi.DTO.App.OrderDTO;
using AdminApi.Models;
using AdminApi.Models.App.Orders;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Order> _OrderRepo;
        private readonly ISqlRepository<OrderItem> _OrderItemRepo;

        public OrderController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<Order> orderRepo,
                                 IConfiguration configuration, ISqlRepository<OrderItem> orderItemRepo)
        {
            _config = config;
            _context = context;
            _OrderRepo = orderRepo;
            _OrderItemRepo = orderItemRepo;
        }

        ///<summary>
        ///Create Order
        ///</summary>
        [HttpPost]
        public IActionResult OrderCreate(CreateOrderDTO createOrderDTO)
        {

            try
            {
                Order order = new Order();

                order.BhaktaId = createOrderDTO.BhaktaId;
                order.TotalQuantity = createOrderDTO.TotalQuantity;
                order.TotalAmount = createOrderDTO.TotalAmount;

                order.CreatedBy = createOrderDTO.CreatedBy;
                order.CreatedOn = System.DateTime.Now;
                var obj = _OrderRepo.Insert(order);
                for (int i = 0; i < createOrderDTO.CreateOrderItemDTOs.Count; i++)
                {
                    OrderItem orderItem = new OrderItem();
                    orderItem.OrderId = obj.OrderId;
                    orderItem.ProductId = createOrderDTO.CreateOrderItemDTOs[i].ProductId;
                    orderItem.Quantity = createOrderDTO.CreateOrderItemDTOs[i].Quantity;
                    orderItem.Amount = createOrderDTO.CreateOrderItemDTOs[i].Amount;
                    orderItem.CreatedBy = createOrderDTO.CreatedBy;
                    orderItem.CreatedOn = System.DateTime.Now;

                    var orderitemobj = _OrderItemRepo.Insert(orderItem);
                }
                return Ok(createOrderDTO);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        ///<summary>
        ///Update Order
        ///</summary>
        [HttpPost]
        public ActionResult UpdateOrder(UpdateOrderDTO updateOrderDTO)
        {
            try
            {
                var objOrder = _context.Orders.SingleOrDefault(opt => opt.OrderId == updateOrderDTO.OrderId);
                if (objOrder != null)
                {
                    objOrder.BhaktaId = updateOrderDTO.BhaktaId;
                    objOrder.TotalQuantity = updateOrderDTO.TotalQuantity;
                    objOrder.TotalAmount = updateOrderDTO.TotalAmount;
                    objOrder.UpdatedBy = updateOrderDTO.UpdatedBy;
                    objOrder.UpdatedOn = System.DateTime.Now;
                    for (int i = 0; i < updateOrderDTO.UpdateOrderItemDTOs.Count; i++)
                    {
                        OrderItem orderItem = new OrderItem();
                        orderItem.OrderId = updateOrderDTO.OrderId;
                        orderItem.ProductId = updateOrderDTO.UpdateOrderItemDTOs[i].ProductId;
                        orderItem.Quantity = updateOrderDTO.UpdateOrderItemDTOs[i].Quantity;
                        orderItem.Amount = updateOrderDTO.UpdateOrderItemDTOs[i].Amount;
                        orderItem.CreatedBy = updateOrderDTO.UpdatedBy;
                        orderItem.UpdatedOn = DateTime.Now;

                    }
                    _context.SaveChanges();
                    return Ok(updateOrderDTO);
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
        ///Get Order List
        ///</summary>
        [HttpGet]
        public ActionResult GetAllOrderList()
        {
            try
            {
                var list = (from u in _context.Orders
                            join c in _context.Bhaktas on u.BhaktaId equals c.BhaktaId
                            select new
                            {
                                u.OrderId,
                                u.BhaktaId,
                                c.BhaktaName,
                                u.TotalQuantity,
                                u.TotalAmount,
                                u.IsDeleted,
                                OrderItem = (from r in _context.OrderItems
                                         join s in _context.Products on r.ProductId equals s.ProductId
                                         select new
                                         {
                                             r.OrderId,
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
        ///Get Single Order by ID
        ///</summary>
        [HttpGet("{OrderId}")]
        public ActionResult GetSingleOrder(int OrderId)
        {
            try
            {
                var list = (from u in _context.Orders
                            join c in _context.Bhaktas on u.BhaktaId equals c.BhaktaId

                            select new
                            {
                                u.OrderId,
                                u.BhaktaId,
                                c.BhaktaName,
                                u.TotalQuantity,
                                u.TotalAmount,
                                u.IsDeleted,
                                OrderItem = _context.OrderItems
                                .Where(x => x.OrderId == u.OrderId)
                                .Select(x => new CreateOrderItemDTO
                                {
                                    OrderId = x.OrderId,
                                    ProductId = x.ProductId,
                                    Quantity = x.Quantity,
                                    Amount = x.Amount,
                                    CreatedBy = x.CreatedBy
                                }).ToList(),
                            }).Where(x => x.OrderId == OrderId && x.IsDeleted == false).Distinct().ToList();

                int totalRecords = list.Count();

                return Ok(new { data = list, recordsTotal = totalRecords, recordsFiltered = totalRecords });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Delete Single Order by ID
        ///</summary>
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteOrder(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Orders.SingleOrDefault(opt => opt.OrderId == Id);
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
        ///Get Order List by Bhakta ID
        ///</summary>
        [HttpGet("{BhaktaId}")]
        public ActionResult GetOrderListbyBhaktaId(int BhaktaId)
        {
            try
            {
                var list = (from u in _context.Orders
                            join t in _context.Bhaktas on u.BhaktaId equals t.BhaktaId
                            where u.BhaktaId == BhaktaId
                            select new
                            {
                                u.OrderId,
                                u.BhaktaId,
                                u.TotalQuantity,
                                u.TotalAmount,
                                u.IsDeleted,
                                OrderItem = (from r in _context.OrderItems
                                             join s in _context.Products on r.ProductId equals s.ProductId
                                             where r.OrderId == u.OrderId
                                             select new
                                             {
                                                 r.OrderId,
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
    }
}
