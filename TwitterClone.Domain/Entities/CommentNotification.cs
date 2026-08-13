using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class CommentNotification : Notification
    {
        public CommentNotification(string commentByUser) : base("Comment")
        {
            CommentByUserId = commentByUser;
        }

        public string CommentByUserId { get; set; }

        public string notificationMessage (string message)
        {
            Message = message;
            return $"Dear User  : {Message}";
        }
    }
}
