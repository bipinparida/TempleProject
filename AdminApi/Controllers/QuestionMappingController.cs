using AdminApi.DTO.App.PoojaCategoryDTO;
using AdminApi.Models;
using AdminApi.Models.App.Questions;
using AdminApi.Models.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System;
using AdminApi.DTO.App.QuestionDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionMappingController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<QuestionMapping> _QuestionMappingRepo;
        public QuestionMappingController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<QuestionMapping> questionMappingRepo)
        {
            _config = config;
            _context = context;
            _QuestionMappingRepo = questionMappingRepo;
        }

        [HttpPost]
        public IActionResult QuestionMappingCreate(CreateQuestionMappingDTO createQuestionMappingDTO)
        {
            var objcheck = _context.QuestionMappings.SingleOrDefault(opt => opt.PanditId == createQuestionMappingDTO.PanditId && opt.QuestionId == createQuestionMappingDTO.QuestionId && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    QuestionMapping questionMapping = new QuestionMapping();

                    questionMapping.PanditId = createQuestionMappingDTO.PanditId;
                    questionMapping.QuestionId = createQuestionMappingDTO.QuestionId;

                    questionMapping.CreatedBy = createQuestionMappingDTO.CreatedBy;
                    questionMapping.CreatedOn = System.DateTime.Now;
                    var obj = _QuestionMappingRepo.Insert(questionMapping);
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
        public ActionResult UpdateQuestionMapping(UpdateQuestionMappingDTO updateQuestionMappingDTO)
        {
            try
            {
                var objQuestionMapping = _context.QuestionMappings.SingleOrDefault(opt => opt.QuestionMappingId == updateQuestionMappingDTO.QuestionMappingId);
               
                var existingQuestionMapping = _context.QuestionMappings.SingleOrDefault(opt => opt.PanditId == updateQuestionMappingDTO.PanditId && opt.QuestionId != updateQuestionMappingDTO.QuestionId && opt.QuestionMappingId != updateQuestionMappingDTO.QuestionMappingId && opt.IsDeleted == false);

                if (existingQuestionMapping != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Question..!" });
                }

                objQuestionMapping.PanditId = updateQuestionMappingDTO.PanditId;
                objQuestionMapping.QuestionId = updateQuestionMappingDTO.QuestionId;

                objQuestionMapping.UpdatedBy = updateQuestionMappingDTO.CreatedBy;
                objQuestionMapping.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objQuestionMapping);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet]
        public ActionResult GetQuestionMappingList()
        {
            try
            {
                var list = (from u in _context.QuestionMappings
                            join c in _context.Pandits on u.PanditId equals c.PanditId
                            join d in _context.Questions on u.QuestionId equals d.QuestionId

                            select new
                            {
                                u.QuestionMappingId,
                                u.PanditId,
                                u.QuestionId,
                                c.PanditName,
                                d.QuestionName,
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
        [HttpGet("{QuestionMappingId}")]
        public ActionResult GetSingleQuestionMapping(int QuestionMappingId)
        {
            try
            {
                var singleQuestionMapping = _QuestionMappingRepo.SelectById(QuestionMappingId);
                return Ok(singleQuestionMapping);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteQuestionMapping(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.QuestionMappings.SingleOrDefault(opt => opt.QuestionMappingId == Id);
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
