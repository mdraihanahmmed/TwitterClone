namespace TwitterClone.Domain.Entities
{
    public abstract class Notification : BaseEntity
    {
    

        public Notification(string notificationType) : base(Guid.NewGuid())
        {
            Type = notificationType;
        }

    

        public Guid UserId { get; private set; }
       

        public string Type { get; set; }
       

        protected string Message { get; set; }
       

        public bool IsRead { get; set; }

        public abstract string GetMessage();

     
    }
}