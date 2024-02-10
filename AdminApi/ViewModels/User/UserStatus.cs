using System;

namespace AdminApi.ViewModels.User
{
    public class UserStatus
    {
        public int TotalUser { get; set; }	 
        public int ActiveUser { get; set; }
        public int InActiveUser { get; set; }
        public int AdminUser { get; set; }   
        public int ActivePandit { get; set; }   
        public int ActiveBhakta { get; set; }   
        public int ActiveTemple { get; set; }   
    }
}