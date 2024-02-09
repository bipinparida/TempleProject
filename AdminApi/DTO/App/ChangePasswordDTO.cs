using System;

namespace AdminApi.DTO.App
{
	public class ChangePasswordDTO
	{
		public Int64? ChangePasswordId { get; set; }
		public string? UserMobileNumber { get; set; } //UserName For Login
		public string OldPassword { get; set; }
		public string NewPassword { get; set; }
		public string RetypePassword { get; set; }
		public Int64 CreatedBy { get; set; }
	}
}
