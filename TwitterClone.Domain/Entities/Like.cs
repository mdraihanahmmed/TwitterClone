

namespace TwitterClone.Domain.Entities
{
    public class Like : BaseEntity
    {
   


        public Like() : base(Guid.NewGuid())
        {

            
        }

       

        public Guid UserId { get; private set; }
     
        public Guid TweetId { get; private set; }
       
     

    }
}
