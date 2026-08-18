using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public SystemNotification (Guid systemNotification) : base("system")
        {
            SystemnNotificationId = systemNotification;
        }

        public Guid SystemnNotificationId { get; set; }

        public string notificationMessage(string message)
        {
            Message = message;
            return $"Hey!  {Message}";
        }

        public override string GetMessage()
        {
            return $"System Notification: {Message}";
        }
    }
}
