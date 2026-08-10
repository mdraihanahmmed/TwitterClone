using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class SystemNotification : Notification
    {
        public SystemNotification (string systemNotification) : base(systemNotification)
        {
            SystemnNotificationId = systemNotification;
        }

        public string SystemnNotificationId { get; set; }

        public string notificationMessage(string message)
        {
            Message = message;
            return $"Hey!  {Message}";
        }


    }
}
