namespace AdminApi.DTO.App.PushNotificationDTO
{
    public class CreatePushNotificationDTO
    {
        public int PanditId { get; set; }
        public string FCMToken { get; set; }

        public int CreatedBy { get; set; }
    }

    public class UpdatePushNotificationDTO
    {
        public int PushNotificationId { get; set; }
        public int PanditId { get; set; }
        public string FCMToken { get; set; }

        public int UpdatedBy { get; set; }
    }
}
