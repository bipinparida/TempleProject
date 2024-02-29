using AdminApi.Models.App.Bhaktas;
using AdminApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using AdminApi.DTO.App;
using AdminApi.Models.App.Pandits;

namespace AdminApi.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class UserLoginController : Controller
	{
		private readonly IConfiguration _config;
		private readonly AppDbContext _context;

		public UserLoginController(IConfiguration config,
								 AppDbContext context
								 )
		{
			_config = config;
			_context = context;
		}

        //[HttpGet("{UserMobileNumber}/{Password}")]
        //public IActionResult UserLogin(string UserMobileNumber, string Password)
        //{
        //	var pandit = _context.Pandits.FirstOrDefault(x => x.PrimaryPhone == UserMobileNumber);
        //	var bhakta = _context.Bhaktas.FirstOrDefault(x => x.PrimaryPhone == UserMobileNumber);

        //	if (pandit == null && bhakta == null)
        //	{
        //		return BadRequest("UserMobileNumber is incorrect or Number not in use");
        //	}

        //	else if (pandit != null)
        //	{
        //		if (pandit.IsApprove == true)
        //		{
        //			if (pandit.Password == Password)
        //			{
        //				return Ok(new { pandit = pandit });
        //			}
        //			else
        //			{
        //				return BadRequest("Mobile Number is correct but the Password is wrong");
        //			}
        //		}
        //		else
        //		{
        //			return BadRequest("Pandit is not approved");
        //		}
        //	}

        //	else if (bhakta != null)
        //	{
        //		if (bhakta.Password == Password)
        //		{
        //			return Ok(new { bhakta = bhakta });
        //		}
        //		else
        //		{
        //			return BadRequest("Mobile Number is correct but the Password is wrong");
        //		}
        //	}

        //	else
        //	{
        //		return BadRequest("Mobile Number is correct but the Password is wrong");
        //	}
        //}





        //[HttpGet("{UserMobileNumber}/{Password}")]
        //public IActionResult UserLogin(string UserMobileNumber, string Password)
        //{
        //	var pandit = _context.Pandits.FirstOrDefault(x => x.PrimaryPhone == UserMobileNumber);
        //	var bhakta = _context.Bhaktas.FirstOrDefault(x => x.PrimaryPhone == UserMobileNumber);

        //	if (pandit == null && bhakta == null)
        //	{
        //		return BadRequest("UserMobileNumber is incorrect or Number not in use");
        //	}

        //	else if (pandit != null && bhakta != null)
        //	{
        //		// Both pandit and bhakta have the same mobile number
        //		if (pandit.Password == Password || bhakta.Password == Password)
        //		{
        //			if (pandit.Password == Password)
        //			{
        //				if (pandit.IsApprove == true)
        //				{
        //					return Ok(new { pandit = pandit });
        //				}
        //				else
        //				{
        //					return BadRequest("Pandit is not approved");
        //				}
        //			}
        //			else
        //			{
        //				return Ok(new { bhakta = bhakta });
        //			}
        //		}
        //		else
        //		{
        //			return BadRequest("Mobile Number is correct but the Password is wrong");
        //		}
        //	}

        //	else if (pandit != null)
        //	{
        //		if (pandit.IsApprove == true)
        //		{
        //			if (pandit.Password == Password)
        //			{
        //				return Ok(new { pandit = pandit });
        //			}
        //			else
        //			{
        //				return BadRequest("Mobile Number is correct but the Password is wrong");
        //			}
        //		}
        //		else
        //		{
        //			return BadRequest("Pandit is not approved");
        //		}
        //	}

        //	else if (bhakta != null)
        //	{
        //		if (bhakta.Password == Password)
        //		{
        //			return Ok(new { bhakta = bhakta });
        //		}
        //		else
        //		{
        //			return BadRequest("Mobile Number is correct but the Password is wrong");
        //		}
        //	}

        //	else
        //	{
        //		return BadRequest("Mobile Number is correct but the Password is wrong");
        //	}
        //}


        //[HttpGet("{UserMobileNumber}/{Password}")]
        //public IActionResult UserLogin(string UserMobileNumber, string Password)
        //{
        //    var pandit = _context.Pandits.FirstOrDefault(x => x.PrimaryPhone == UserMobileNumber);
        //    var bhakta = _context.Bhaktas.FirstOrDefault(x => x.PrimaryPhone == UserMobileNumber);

        //    if (pandit == null && bhakta == null)
        //    {
        //        return BadRequest("UserMobileNumber is incorrect or Number not in use");
        //    }

        //    else if (pandit != null && bhakta != null)
        //    {
        //        // Both pandit and bhakta have the same mobile number
        //        if (pandit.Password == Password || bhakta.Password == Password)
        //        {
        //            if (pandit.Password == Password)
        //            {
        //                if (pandit.IsApprove == true)
        //                {
        //                    return Ok(new { pandit = pandit });
        //                }
        //                else if (pandit.Reject == true)
        //                {
        //                    return BadRequest("Pandit is rejected");
        //                }
        //                else
        //                {
        //                    return BadRequest("Pandit is not approved");
        //                }
        //            }
        //            else
        //            {
        //                return Ok(new { bhakta = bhakta });
        //            }
        //        }
        //        else
        //        {
        //            return BadRequest("Mobile Number is correct but the Password is wrong");
        //        }
        //    }

        //    else if (pandit != null)
        //    {
        //        if (pandit.IsApprove == true)
        //        {
        //            if (pandit.Password == Password)
        //            {
        //                return Ok(new { pandit = pandit });
        //            }
        //            else
        //            {
        //                return BadRequest("Mobile Number is correct but the Password is wrong");
        //            }
        //        }
        //        else if (pandit.Reject == true)
        //        {
        //            return BadRequest("Pandit is rejected");
        //        }
        //        else
        //        {
        //            return BadRequest("Pandit is not approved");
        //        }
        //    }

        //    else if (bhakta != null)
        //    {
        //        if (bhakta.Password == Password)
        //        {
        //            return Ok(new { bhakta = bhakta });
        //        }
        //        else
        //        {
        //            return BadRequest("Mobile Number is correct but the Password is wrong");
        //        }
        //    }

        //    else
        //    {
        //        return BadRequest("Mobile Number is correct but the Password is wrong");
        //    }
        //}


        ///<summary>
        ///UserLogin by Mobile Number and Password
        ///</summary>
        [HttpGet("{UserMobileNumber}/{Password}")]
        public IActionResult UserLogin(string UserMobileNumber, string Password)
        {
            var pandit = _context.Pandits.FirstOrDefault(x => x.PrimaryPhone == UserMobileNumber);
            var bhakta = _context.Bhaktas.FirstOrDefault(x => x.PrimaryPhone == UserMobileNumber);

            if (pandit == null && bhakta == null)
            {
                return BadRequest("UserMobileNumber is incorrect or Number not in use");
            }
            else if (pandit != null && bhakta != null)
            {
                // Both pandit and bhakta have the same mobile number
                if (pandit.Password == Password)
                {
                    return Ok(new { pandit = pandit });
                }
                else if (bhakta.Password == Password)
                {
                    return Ok(new { bhakta = bhakta });
                }
                else
                {
                    return BadRequest("Mobile Number is correct but the Password is wrong");
                }
            }
            else if (pandit != null)
            {
                if (pandit.Password == Password)
                {
                    return Ok(new { pandit = pandit });
                }
                else
                {
                    return BadRequest("Mobile Number is correct but the Password is wrong");
                }
            }
            else if (bhakta != null)
            {
                if (bhakta.Password == Password)
                {
                    return Ok(new { bhakta = bhakta });
                }
                else
                {
                    return BadRequest("Mobile Number is correct but the Password is wrong");
                }
            }
            else
            {
                return BadRequest("Mobile Number is correct but the Password is wrong");
            }
        }


        ///<summary>
        ///Pandit Login by Mobile Number and Password
        ///</summary>
        [HttpGet("{UserMobileNumber}/{Password}")]
        public IActionResult PanditLogin(string UserMobileNumber, string Password)
        {
            var pandit = _context.Pandits.FirstOrDefault(x => x.PrimaryPhone == UserMobileNumber);

            if (pandit == null)
            {
                return BadRequest("Pandit with provided Mobile Number not found");
            }
            else if (pandit.Password == Password)
            {
                return Ok(new { pandit = pandit });
            }
            else
            {
                return BadRequest("Incorrect Password");
            }
        }

        ///<summary>
        ///Bhakta Login by Mobile Number and Password
        ///</summary>
        [HttpGet("{UserMobileNumber}/{Password}")]
        public IActionResult BhaktaLogin(string UserMobileNumber, string Password)
        {
            var bhakta = _context.Bhaktas.FirstOrDefault(x => x.PrimaryPhone == UserMobileNumber);

            if (bhakta == null)
            {
                return BadRequest("Bhakta with provided Mobile Number not found");
            }
            else if (bhakta.Password == Password)
            {
                return Ok(new { bhakta = bhakta });
            }
            else
            {
                return BadRequest("Incorrect Password");
            }
        }




        //[HttpPost]
        //public IActionResult ChangePassword(ChangePasswordDTO changePasswordDTO)
        //{
        //	var pandit = _context.Pandits.FirstOrDefault(x => x.PrimaryPhone == changePasswordDTO.UserMobileNumber);
        //	var bhakta = _context.Bhaktas.FirstOrDefault(x => x.PrimaryPhone == changePasswordDTO.UserMobileNumber);

        //	if (pandit == null && bhakta == null)
        //	{
        //		return BadRequest("User not found");
        //	}

        //	var user = (pandit != null) ? (object)pandit : bhakta;

        //	if (user is Pandit && ((Pandit)user).Password != changePasswordDTO.OldPassword)
        //	{
        //		return BadRequest("Old password is incorrect");
        //	}
        //	else if (user is Bhakta && ((Bhakta)user).Password != changePasswordDTO.OldPassword)
        //	{
        //		return BadRequest("Old password is incorrect");
        //	}

        //	if (changePasswordDTO.NewPassword != changePasswordDTO.RetypePassword)
        //	{
        //		return BadRequest("New password and retype password do not match");
        //	}

        //	if (user is Pandit)
        //	{
        //		var panditToUpdate = (Pandit)user;
        //		panditToUpdate.Password = changePasswordDTO.NewPassword;
        //	}
        //	else if (user is Bhakta)
        //	{
        //		var customerToUpdate = (Bhakta)user;
        //		customerToUpdate.Password = changePasswordDTO.NewPassword;
        //	}

        //	_context.SaveChanges();

        //	return Ok("Password changed successfully");
        //}


        ///<summary>
        ///Change Password
        ///</summary>
        [HttpPost]
		public IActionResult ChangePassword(ChangePasswordDTO changePasswordDTO)
		{
			var pandit = _context.Pandits.FirstOrDefault(x => x.PrimaryPhone == changePasswordDTO.UserMobileNumber);
			var bhakta = _context.Bhaktas.FirstOrDefault(x => x.PrimaryPhone == changePasswordDTO.UserMobileNumber);

			if (pandit == null && bhakta == null)
			{
				return BadRequest("User not found");
			}

			if (pandit != null && bhakta != null)
			{
				if (pandit.Password != changePasswordDTO.OldPassword && bhakta.Password != changePasswordDTO.OldPassword)
				{
					return BadRequest("Old password is incorrect");
				}
				if (pandit.Password == changePasswordDTO.OldPassword)
				{
					if (changePasswordDTO.NewPassword != changePasswordDTO.RetypePassword)
					{
						return BadRequest("New password and retype password do not match");
					}
					pandit.Password = changePasswordDTO.NewPassword;
				}
				else if (bhakta.Password == changePasswordDTO.OldPassword)
				{
					if (changePasswordDTO.NewPassword != changePasswordDTO.RetypePassword)
					{
						return BadRequest("New password and retype password do not match");
					}
					bhakta.Password = changePasswordDTO.NewPassword;
				}
			}
			else
			{
				var user = (pandit != null) ? (object)pandit : bhakta;
				if (user is Pandit && ((Pandit)user).Password != changePasswordDTO.OldPassword)
				{
					return BadRequest("Old password is incorrect");
				}
				else if (user is Bhakta && ((Bhakta)user).Password != changePasswordDTO.OldPassword)
				{
					return BadRequest("Old password is incorrect");
				}

				if (changePasswordDTO.NewPassword != changePasswordDTO.RetypePassword)
				{
					return BadRequest("New password and retype password do not match");
				}

				if (user is Pandit)
				{
					var panditToUpdate = (Pandit)user;
					panditToUpdate.Password = changePasswordDTO.NewPassword;
				}
				else if (user is Bhakta)
				{
					var bhaktaToUpdate = (Bhakta)user;
					bhaktaToUpdate.Password = changePasswordDTO.NewPassword;
				}
			}

			_context.SaveChanges();

			return Ok("Password changed successfully");
		}



        ///<summary>
        ///Pandit Change Password
        ///</summary>

        [HttpPost]
        public IActionResult PanditChangePassword(ChangePasswordDTO changePasswordDTO)
        {
            var pandit = _context.Pandits.FirstOrDefault(x => x.PrimaryPhone == changePasswordDTO.UserMobileNumber);

            if (pandit == null)
            {
                return BadRequest("Pandit not found");
            }

            if (pandit.Password != changePasswordDTO.OldPassword)
            {
                return BadRequest("Old password is incorrect");
            }

            if (changePasswordDTO.NewPassword != changePasswordDTO.RetypePassword)
            {
                return BadRequest("New password and retype password do not match");
            }

            pandit.Password = changePasswordDTO.NewPassword;
            _context.SaveChanges();

            return Ok("Pandit password changed successfully");
        }



        ///<summary>
        ///Bhakta Change Password
        ///</summary>
        [HttpPost]
        public IActionResult BhaktaChangePassword(ChangePasswordDTO changePasswordDTO)
        {
            var bhakta = _context.Bhaktas.FirstOrDefault(x => x.PrimaryPhone == changePasswordDTO.UserMobileNumber);

            if (bhakta == null)
            {
                return BadRequest("Bhakta not found");
            }

            if (bhakta.Password != changePasswordDTO.OldPassword)
            {
                return BadRequest("Old password is incorrect");
            }

            if (changePasswordDTO.NewPassword != changePasswordDTO.RetypePassword)
            {
                return BadRequest("New password and retype password do not match");
            }

            bhakta.Password = changePasswordDTO.NewPassword;
            _context.SaveChanges();

            return Ok("Bhakta password changed successfully");
        }


    }
}
