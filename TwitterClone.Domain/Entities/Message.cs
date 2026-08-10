namespace TwitterClone.Domain.Entities
{
    public class Message : BaseEntity
    {


        public Message() : base(Guid.NewGuid())
        {
            
        }

        

        public Guid SenderId { get; private set; }
    

        public Guid ReceiverId { get; private set; }
       

        public string Content { get; set; }
       

        public DateTime SentAt { get; private set; }
       
        public bool IsRead { get; set; }
   

       

    }
}