using AdminApi.Models.App.PushNotifications;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.Helper;
using System;
using AdminApi.DTO.App.PushNotificationDTO;
using System.Linq;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PushNotificationController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<PushNotification> _PushNotificationRepo;
        public PushNotificationController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<PushNotification> PushNotificationRepo)

        {
            _config = config;
            _context = context;
            _PushNotificationRepo = PushNotificationRepo;
        }

        [HttpPost]
        public IActionResult CreatePushNotificationInfo(CreatePushNotificationDTO pushNotificationDTO)
        {
            try
            {
                PushNotification existingPushNotification = _context.PushNotifications.FirstOrDefault(x => x.PanditId == pushNotificationDTO.PanditId);

                if (existingPushNotification != null)
                {
                    existingPushNotification.FCMToken = pushNotificationDTO.FCMToken;
                    existingPushNotification.CreatedBy = pushNotificationDTO.CreatedBy;
                    existingPushNotification.CreatedOn = System.DateTime.Now;

                    _PushNotificationRepo.Update(existingPushNotification);
                    return Ok(existingPushNotification);
                }
                else
                {

                    PushNotification pushNotification = new PushNotification
                    {
                        PanditId = pushNotificationDTO.PanditId,
                        FCMToken = pushNotificationDTO.FCMToken,
                        CreatedBy = pushNotificationDTO.CreatedBy,
                        CreatedOn = System.DateTime.Now
                    };

                    var obj = _PushNotificationRepo.Insert(pushNotification);
                    return Ok(obj);
                }
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public IActionResult GetPushNotificationList()
        {
            try
            {
                var list = (from u in _context.PushNotifications

                            select new
                            {
                                u.PushNotificationId,
                                u.PanditId,
                                u.FCMToken,
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

        [HttpGet("{PushNotificationId}")]
        public IActionResult GetPushNotificationByPushNotificationId(int PushNotificationId)
        {
            try
            {
                var list = (from u in _context.PushNotifications
                            where u.PushNotificationId == PushNotificationId && u.IsDeleted == false

                            select new
                            {
                                u.PushNotificationId,
                                u.PanditId,
                                u.FCMToken,
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


        [HttpPost]
        public ActionResult UpdatePushNotificationInfo(UpdatePushNotificationDTO updatepushNotificationDTO)
        {
            try
            {
                var obj = _context.PushNotifications.SingleOrDefault(opt => opt.PushNotificationId == updatepushNotificationDTO.PushNotificationId);

                obj.PanditId = updatepushNotificationDTO.PanditId;
                obj.FCMToken = updatepushNotificationDTO.FCMToken;
                obj.UpdatedBy = updatepushNotificationDTO.UpdatedBy;
                obj.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(obj);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeletePushNotificationInfo(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.PushNotifications.SingleOrDefault(opt => opt.PushNotificationId == Id);
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
