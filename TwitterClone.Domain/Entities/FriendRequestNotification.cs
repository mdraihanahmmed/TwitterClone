using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    internal class FriendRequestNotification : Notification

    {
        public FriendRequestNotification (Guid friendRequest) : base("Friend Request")
        {
            FriendRequestId = friendRequest;
        }

        public Guid FriendRequestId { get; set; }

        public string notificationMessage (string message)
        {
            Message = message;
            return $"You Have Request From : {Message}";
        }

        public override string GetMessage()
        {
            return $"you got a friend request: {Message}";
        }
    }
}
