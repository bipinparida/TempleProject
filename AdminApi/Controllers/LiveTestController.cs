using AdminApi.Models.App.Questions;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.LiveTest;
using AdminApi.DTO.App.TempleDTO;
using AdminApi.Models.App.Temples;
using AdminApi.Models.Helper;
using System.Linq;
using System;
using AdminApi.DTO.App.LiveTestDTO;
using AdminApi.DTO.App.BhaktaDTO;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LiveTestController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<LiveTest> _LiveTestRepo;

        public LiveTestController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<LiveTest> liveTestRepo)
        {
            _config = config;
            _context = context;
            _LiveTestRepo = liveTestRepo;
        }


        //[HttpPost]
        //public IActionResult LiveTestCreate(CreateLiveTestDTO createLiveTestDTO)
        //{
        //    //var objcheck = _context.LiveTests.SingleOrDefault(opt => opt.QuestionId == createLiveTestDTO.QuestionId && opt.IsDeleted == false);
        //    try
        //    {
        //        //if (objcheck == null)
        //        //{
        //            LiveTest liveTest = new LiveTest();

        //            liveTest.PanditId = createLiveTestDTO.PanditId;
        //            liveTest.QuestionId = createLiveTestDTO.QuestionId;
        //            liveTest.LiveTestAnswer = createLiveTestDTO.LiveTestAnswer;

        //            liveTest.CreatedBy = createLiveTestDTO.CreatedBy;
        //            liveTest.CreatedOn = System.DateTime.Now;
        //            var obj = _LiveTestRepo.Insert(liveTest);
        //            return Ok(obj);
        //        //}
        //        //else if (objcheck != null)
        //        //{
        //        //    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate Question..!" });
        //        //}
        //        //return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });
        //    }

        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }

        //}



        ///<summary>
        ///Create LiveTest
        ///</summary>
        [HttpPost]
        public IActionResult LiveTestCreate(CreateLiveTestDTO createLiveTestDTO)
        {
            try
            {
                // Check if a live test already exists for the given question and pandit
                var existingLiveTest = _context.LiveTests.SingleOrDefault(opt => opt.QuestionId == createLiveTestDTO.QuestionId && opt.PanditId == createLiveTestDTO.PanditId && opt.IsDeleted == false);

                if (existingLiveTest == null)
                {
                    // No existing live test found for the given pandit and question, proceed to create a new one
                    LiveTest liveTest = new LiveTest();
                    liveTest.PanditId = createLiveTestDTO.PanditId;
                    liveTest.QuestionId = createLiveTestDTO.QuestionId;
                    liveTest.LiveTestAnswer = createLiveTestDTO.LiveTestAnswer;
                    liveTest.CreatedBy = createLiveTestDTO.CreatedBy;
                    liveTest.CreatedOn = System.DateTime.Now;

                    var obj = _LiveTestRepo.Insert(liveTest);
                    return Ok(obj);
                }
                else
                {
                    // A live test already exists for the given pandit and question
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "A live test for this question has already been created by this pandit." });
                }
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }



        //[HttpPost]
        //public IActionResult LiveTestCreate(CreateLiveTestDTOs createLiveTestDTO)
        //{
        //    try
        //    {
        //        foreach (var pair in createLiveTestDTO.QuestionAnswerPairs)
        //        {
        //            // Check if a live test already exists for the given question and pandit
        //            var existingLiveTest = _context.LiveTests.SingleOrDefault(opt =>
        //                opt.QuestionId == pair.QuestionId &&
        //                opt.PanditId == createLiveTestDTO.PanditId &&
        //                opt.IsDeleted == false);

        //            if (existingLiveTest == null)
        //            {
        //                // No existing live test found for the given pandit and question, proceed to create a new one
        //                LiveTest liveTest = new LiveTest
        //                {
        //                    PanditId = createLiveTestDTO.PanditId,
        //                    QuestionId = pair.QuestionId,
        //                    LiveTestAnswer = pair.LiveTestAnswer,
        //                    CreatedBy = createLiveTestDTO.CreatedBy,
        //                    CreatedOn = System.DateTime.Now
        //                };

        //                var obj = _LiveTestRepo.Insert(liveTest);
        //                // You may want to collect the created objects and return them after the loop completes
        //            }
        //            else
        //            {
        //                // A live test already exists for the given pandit and question
        //                return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "A live test for this question has already been created by this pandit." });
        //            }
        //        }

        //        // Return success response after all tests are created
        //        return Ok(new Confirmation { Status = "Success", ResponseMsg = "Live tests created successfully." });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
        //    }
        //}




        ///<summary>
        ///Get LiveTest List
        ///</summary>
        [HttpGet]
        public ActionResult GetLiveTestList()
        {
            try
            {
                var list = (from u in _context.LiveTests
                            join q in _context.Questions on u.QuestionId equals q.QuestionId
                            join p in _context.Pandits on u.PanditId equals p.PanditId

                            select new
                            {
                                u.LiveTestId,
                                u.LiveTestAnswer,
                                u.QuestionId,
                                q.QuestionName,
                                u.PanditId,
                                p.PanditName,

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
        ///Get Single LiveTest by ID
        ///</summary>
        [HttpGet("{LiveTestId}")]
        public ActionResult GetSingleLiveTest(int LiveTestId)
        {
            try
            {
                var singleTemple = _LiveTestRepo.SelectById(LiveTestId);
                return Ok(singleTemple);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Update LiveTest
        ///</summary>
        [HttpPost]
        public ActionResult UpdateLiveTest(UpdateLiveTestDTO updateLiveTestDTO)
        {
            try
            {
                var objLiveTest = _context.LiveTests.SingleOrDefault(opt => opt.LiveTestId == updateLiveTestDTO.LiveTestId);


                objLiveTest.PanditId = updateLiveTestDTO.PanditId;
                objLiveTest.QuestionId = updateLiveTestDTO.QuestionId;
                objLiveTest.LiveTestAnswer = updateLiveTestDTO.LiveTestAnswer;


                objLiveTest.UpdatedBy = updateLiveTestDTO.UpdatedBy;
                objLiveTest.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objLiveTest);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        ///<summary>
        ///Delete Single LiveTest by ID
        ///</summary>
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteLiveTest(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.LiveTests.SingleOrDefault(opt => opt.LiveTestId == Id);
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
        ///Get LiveTest List by Pandit ID
        ///</summary>
        [HttpGet("{PanditId}")]
        public ActionResult GetLiveTestListbyPanditId(int PanditId)
        {
            try
            {
                var list = (from u in _context.LiveTests
                            join q in _context.Questions on u.QuestionId equals q.QuestionId
                            join p in _context.Pandits on u.PanditId equals p.PanditId

                            select new
                            {
                                u.LiveTestId,
                                u.LiveTestAnswer,
                                u.PanditId,
                                p.PanditName,
                                u.QuestionId,
                                q.QuestionName,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.PanditId == PanditId).ToList();

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
