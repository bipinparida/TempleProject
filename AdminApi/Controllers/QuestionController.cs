using AdminApi.Models.App.Location;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Questions;
using AdminApi.DTO.App.LocationDTO;
using AdminApi.Models.Helper;
using System.Linq;
using System;
using AdminApi.DTO.App.QuestionDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Question> _QuestionRepo;

        public QuestionController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Question> questionRepo)
        {
            _config = config;
            _context = context;
            _QuestionRepo = questionRepo;
        }

        [HttpPost]
        public IActionResult QuestionCreate(CreateQuestionDTO createQuestionDTO)
        {
            var objcheck = _context.Questions.SingleOrDefault(opt => opt.QuestionName == createQuestionDTO.QuestionName && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    Question question = new Question();

                    question.QuestionName = createQuestionDTO.QuestionName;

                    question.CreatedBy = createQuestionDTO.CreatedBy;
                    question.CreatedOn = System.DateTime.Now;
                    var obj = _QuestionRepo.Insert(question);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Question..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        [HttpPost]
        public ActionResult UpdateQuestion(UpdateQuestionDTO updateQuestionDTO)
        {
            try
            {
                var objQuestion = _context.Questions.SingleOrDefault(opt => opt.QuestionId == updateQuestionDTO.QuestionId);

                var existingQuestion = _context.Questions.SingleOrDefault(opt => opt.QuestionName == updateQuestionDTO.QuestionName && opt.QuestionId != updateQuestionDTO.QuestionId && opt.IsDeleted == false);

                if (existingQuestion != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Question..!" });
                }

                objQuestion.QuestionName = updateQuestionDTO.QuestionName;
                objQuestion.UpdatedBy = updateQuestionDTO.CreatedBy;
                objQuestion.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objQuestion);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet]
        public ActionResult GetQuestionList()
        {
            try
            {
                var list = (from u in _context.Questions

                            select new
                            {
                                u.QuestionName,
                                u.QuestionId,
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

        [HttpGet("{QuestionId}")]
        public ActionResult GetSingleQuestion(int QuestionId)
        {
            try
            {
                var singleQuestion = _QuestionRepo.SelectById(QuestionId);
                return Ok(singleQuestion);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteQuestion(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Questions.SingleOrDefault(opt => opt.QuestionId == Id);
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
