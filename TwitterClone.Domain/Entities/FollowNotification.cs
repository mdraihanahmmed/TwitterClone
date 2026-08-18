using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class FollowNotification : Notification
    {
        public FollowNotification(Guid followUser) : base("follow")
        {
            followUserId = followUser;
        }

        public Guid followUserId { get; set; }

        public string followMessage(string message)
        {
            Message = message;
            return Message;
        }

        public override string GetMessage()
        {
            return $"you got new follower: {Message}";
        }
  
    }
}
