using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    internal class FriendRequestNotification : Notification

    {
        public FriendRequestNotification (string friendRequest) : base("Friend Request")
        {
            FriendRequestId = friendRequest;
        }

        public string FriendRequestId { get; set; }

        public string notificationMessage (string message)
        {
            Message = message;
            return $"You Have Request From : {Message}";
        }
       
    }
}
