

namespace TwitterClone.Domain.Entities
{
    public class MentionNotification : Notification
    {

        public MentionNotification (Guid mentinonUser) : base("mention")
        {
            mentionNotificationId = mentinonUser;
        }

        public Guid mentionNotificationId { get; set; }

        public string mentionMessage (string message)
        {
            Message = message;
            return Message;
        }

        public override string GetMessage()
        {
            return $"someone mentioned you: {Message}";
        }
    }
}
