﻿using AdminApi.Models.App.Temples;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Feedbacks;
using AdminApi.DTO.App.TempleDTO;
using AdminApi.Models.Helper;
using System.Linq;
using System;
using AdminApi.DTO.App.FeedbackDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FeedbackController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Feedback> _FeedbackRepo;
        public FeedbackController(IConfiguration config,
                                 AppDbContext context,
                                 ISqlRepository<Feedback> feedbackRepo)
        {
            _config = config;
            _context = context;
            _FeedbackRepo = feedbackRepo;
        }
        [HttpPost]
        public IActionResult FeedbackCreate(CreateFeedbackDTO createFeedbackDTO)
        {
            //var objcheck = _context.Feedbacks.SingleOrDefault(opt => opt.TempleName == createTempleDTO.TempleName && opt.IsDeleted == false);
            try
            {
                //if (objcheck == null)
                //{
                    Feedback feedback = new Feedback();

                    feedback.BhaktaId = createFeedbackDTO.BhaktaId;
                    feedback.PanditId = createFeedbackDTO.PanditId;
                    feedback.FeedbackMessage = createFeedbackDTO.FeedbackMessage;

                    feedback.CreatedBy = createFeedbackDTO.CreatedBy;
                    feedback.CreatedOn = System.DateTime.Now;
                    var obj = _FeedbackRepo.Insert(feedback);
                    return Ok(obj);
                //}
                //else if (objcheck != null)
                //{
                //    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Temple..!" });
                //}
                //return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }
        [HttpGet]
        public ActionResult GetFeedbackList()
        {
            try
            {
                var list = (from u in _context.Feedbacks
                            join c in _context.Bhaktas on u.BhaktaId equals c.BhaktaId
                            join d in _context.Pandits on u.PanditId equals d.PanditId

                            select new
                            {
                                u.FeedbackId,
                                u.BhaktaId,
                                u.PanditId,
                                c.BhaktaName,
                                d.PanditName,
                                u.FeedbackMessage,
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
        [HttpGet("{FeedbackId}")]
        public ActionResult GetSingleFeedback(int FeedbackId)
        {
            try
            {
                var singleFeedback = _FeedbackRepo.SelectById(FeedbackId);
                return Ok(singleFeedback);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpPost]
        public ActionResult UpdateFeedback(UpdateFeedbackDTO updateFeedbackDTO)
        {
            try
            {
                var objFeedback = _context.Feedbacks.SingleOrDefault(opt => opt.FeedbackId == updateFeedbackDTO.FeedbackId);

                // Check if the new country name is not the same as any existing non-deleted country
                //var existingTemple = _context.Temples.SingleOrDefault(opt => opt.TempleName == updateTempleDTO.TempleName && opt.TempleId != updateTempleDTO.TempleId && opt.IsDeleted == false);

                //if (existingTemple != null)
                //{
                //    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate TempleName..!" });
                //}
                objFeedback.BhaktaId = updateFeedbackDTO.BhaktaId;
                objFeedback.PanditId = updateFeedbackDTO.PanditId;
                objFeedback.FeedbackMessage = updateFeedbackDTO.FeedbackMessage;

                objFeedback.UpdatedBy = updateFeedbackDTO.CreatedBy;
                objFeedback.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objFeedback);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteFeedback(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Feedbacks.SingleOrDefault(opt => opt.FeedbackId == Id);
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