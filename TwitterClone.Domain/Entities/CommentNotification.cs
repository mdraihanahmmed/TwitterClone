using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class CommentNotification : Notification
    {
        public CommentNotification(Guid commentByUser) : base("Comment")
        {
            CommentByUserId = commentByUser;
        }

        public Guid CommentByUserId { get; set; }

        public string notificationMessage (string message)
        {
            Message = message;
            return $"Dear User  : {Message}";
        }

        public override string GetMessage()
        {
            return $"you got a comment: {Message}";
        }
    }
}
