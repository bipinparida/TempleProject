using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using AdminApi.Models.App.Address;
using AdminApi.Models.Helper;
using System;
using AdminApi.DTO.App.AddressDTO;
using System.Linq;

namespace AdminApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressController : Controller
    {
        private readonly IConfiguration _config;
        private readonly AppDbContext _context;
        private readonly ISqlRepository<Address> _AddressRepo;

        public AddressController(IConfiguration config,
                                AppDbContext context,
                                ISqlRepository<Address> addressRepo)
        {
            _config = config;
            _context = context;
            _AddressRepo = addressRepo;
        }

        ///<summary>
        ///Create Address
        ///</summary>
        [HttpPost]
        public IActionResult AddressCreate(CreateAddressDTO createAddressDTO)
        {
            try
            {
                Address address = new Address();

                address.Name = createAddressDTO.Name;
                address.Pincode = createAddressDTO.Pincode;
                address.CountryId = createAddressDTO.CountryId;
                address.StateId = createAddressDTO.StateId;
                address.CityId = createAddressDTO.CityId;
                address.PrimaryPhone = createAddressDTO.PrimaryPhone;
                address.AlternatePhone = createAddressDTO.AlternatePhone;
                address.MailId = createAddressDTO.MailId;
                address.HouseNumber = createAddressDTO.HouseNumber;


                address.CreatedBy = createAddressDTO.CreatedBy;
                address.CreatedOn = System.DateTime.Now;
                var obj = _AddressRepo.Insert(address);
                return Ok(obj);

            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }

        }

        ///<summary>
        ///Update Address
        ///</summary>
        [HttpPost]
        public ActionResult UpdateAddress(UpdateAddressDTO updateAddressDTO)
        {
            try
            {
                var objAddress = _context.Addresss.SingleOrDefault(opt => opt.AddressId == updateAddressDTO.AddressId);

                objAddress.Name = updateAddressDTO.Name;
                objAddress.Pincode = updateAddressDTO.Pincode;
                objAddress.CountryId = updateAddressDTO.CountryId;
                objAddress.StateId = updateAddressDTO.StateId;
                objAddress.CityId = updateAddressDTO.CityId;
                objAddress.PrimaryPhone = updateAddressDTO.PrimaryPhone;
                objAddress.AlternatePhone = updateAddressDTO.AlternatePhone;
                objAddress.MailId = updateAddressDTO.MailId;
                objAddress.HouseNumber = updateAddressDTO.HouseNumber;


                objAddress.UpdatedBy = updateAddressDTO.UpdatedBy;
                objAddress.UpdatedOn = System.DateTime.Now;
                _context.SaveChanges();
                return Ok(objAddress);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Get Address List
        ///</summary>
        [HttpGet]
        public ActionResult GetAddressList()
        {
            try
            {
                var list = (from u in _context.Addresss
                            join b in _context.Countries on u.CountryId equals b.CountryId
                            join t in _context.States on u.StateId equals t.StateId
                            join p in _context.Cities on u.CityId equals p.CityId
                            join a in _context.Bhaktas on u.CreatedBy equals a.BhaktaId

                            select new
                            {
                                u.AddressId,
                                u.Name,
                                u.Pincode,
                                u.CountryId,
                                a.BhaktaId,
                                a.BhaktaName,
                                b.CountryName,
                                u.StateId,
                                t.StateName,
                                u.CityId,
                                p.CityName,
                                u.PrimaryPhone,
                                u.AlternatePhone,
                                u.MailId,
                                u.HouseNumber,

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
        ///Get Single Address by ID
        ///</summary>
        [HttpGet("{AddressId}")]
        public ActionResult GetSingleAddress(int AddressId)
        {
            try
            {
                var singleAddress = _AddressRepo.SelectById(AddressId);
                return Ok(singleAddress);
            }
            catch (Exception ex)
            {
                return Accepted(new Confirmation { Status = "error", ResponseMsg = ex.Message });
            }
        }

        ///<summary>
        ///Delete Single Address by ID
        ///</summary>
        [HttpGet("{Id}/{DeletedBy}")]
        public ActionResult DeleteAddress(int Id, int DeletedBy)
        {
            try
            {
                var objabout = _context.Addresss.SingleOrDefault(opt => opt.AddressId == Id);
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
        ///Get Address by BhaktaId
        ///</summary>
        [HttpGet("{BhaktaId}/{CreatedBy}")]
        public ActionResult GetAddressByBhaktaId(int BhaktaId)
        {

            try
            {
                var list = (from u in _context.Addresss
                            join b in _context.Countries on u.CountryId equals b.CountryId
                            join t in _context.States on u.StateId equals t.StateId
                            join p in _context.Cities on u.CityId equals p.CityId
                            join a in _context.Bhaktas on u.CreatedBy equals a.BhaktaId

                            select new
                            {
                                u.AddressId,
                                u.Name,
                                u.Pincode,
                                u.CountryId,
                                a.BhaktaId,
                                b.CountryName,
                                u.StateId,
                                t.StateName,
                                u.CityId,
                                p.CityName,
                                u.PrimaryPhone,
                                u.AlternatePhone,
                                u.MailId,
                                u.HouseNumber,
                                u.CreatedBy,
                                u.IsDeleted
                            }).Where(x => x.IsDeleted == false && x.CreatedBy == BhaktaId).ToList();

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
