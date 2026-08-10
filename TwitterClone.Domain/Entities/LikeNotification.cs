using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public LikeNotification (Guid likbyUserId) : base("Like")
        {
            likbyUserId = likbyUserId;
        }
        public string LikeByUserId { get; set; }

        public string notificationMessage (string message)
        {
            Message = message;
            return $"Dear User : {Message}";
        }
    }
}
