using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class LikeNotification : Notification
    {
        public LikeNotification (Guid likbyUserId) : base("Like")
        {
            LikeByUserId = likbyUserId;
        }
        public Guid LikeByUserId { get; set; }

        public string notificationMessage (string message)
        {
            Message = message;
            return $"Dear User : {Message}";
        }

        public override string GetMessage()
        {
            return $"you got a like: {Message}";
        }
    }
}
