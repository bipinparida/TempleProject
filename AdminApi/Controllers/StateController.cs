using AdminApi.Models.App.Location;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.DTO.App.LocationDTO;
using AdminApi.Models.Helper;
using System.Linq;
using System;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StateController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<State> _StateRepo;

        public StateController(IConfiguration config,
                                    AppDbContext context,
                                    ISqlRepository<State> StateRepo)
        {
            _config = config;
            _context = context;
            _StateRepo = StateRepo;
        }


        [HttpPost]
        public IActionResult StateCreate(CreateStateDTO createStateDTO)
        {
            var objcheck = _context.States.SingleOrDefault(opt => opt.StateName == createStateDTO.StateName && opt.IsDeleted == false);
            try
            {
                if (objcheck == null)
                {
                    State state = new State();
                    state.StateName = createStateDTO.StateName;
                    state.CountryId = createStateDTO.CountryId;
                    state.CreatedBy = createStateDTO.CreatedBy;
                    state.CreatedOn = System.DateTime.Now;
                    var obj = _StateRepo.Insert(state);
                    return Ok(obj);
                }
                else if (objcheck != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate StateName..!" });
                }
                return Accepted(new Confirmation { Status = "Error", ResponseMsg = "Something unexpected!" });

            }

            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }


        [HttpGet]
        public ActionResult GetStateList()
        {
            try
            {
                var list = (from u in _context.States
                            join a in _context.Countries on u.CountryId equals a.CountryId

                            select new
                            {
                                u.StateId,
                                u.StateName,
                                a.CountryName,
                                u.CountryId,
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

        //single list
        [HttpGet("{StateId}")]
        public ActionResult GetSingleState(int StateId)
        {
            try
            {
                var singleState = _StateRepo.SelectById(StateId);
                return Ok(singleState);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        //update
        [HttpPost]
        public ActionResult UpdateState(UpdateStateDTO updateStateDTO)
        {
            try
            {
                var objState = _context.States.SingleOrDefault(opt => opt.StateId == updateStateDTO.StateId);

                var existingState = _context.States.SingleOrDefault(opt => opt.StateName == updateStateDTO.StateName && opt.StateId != updateStateDTO.StateId && opt.IsDeleted == false);

                if (existingState != null)
                {
                    return Accepted(new Confirmation { Status = "Duplicate", ResponseMsg = "Duplicate State Name..!" });
                }

                objState.StateName = updateStateDTO.StateName;
                objState.CountryId = updateStateDTO.CountryId;
                objState.UpdatedBy = updateStateDTO.CreatedBy;
                objState.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objState);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteState(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.States.SingleOrDefault(opt => opt.StateId == Id);
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

        [HttpGet("{Countryid}")]
        public ActionResult GetStateListbyCountryid(int Countryid)
        {
            try
            {
                var list = (from u in _context.States
                            join a in _context.Countries on u.CountryId equals a.CountryId

                            select new
                            {
                                u.StateId,
                                u.StateName,
                                a.CountryName,
                                u.CountryId,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.CountryId == Countryid).Distinct().ToList();

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
