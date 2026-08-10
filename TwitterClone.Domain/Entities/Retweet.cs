namespace TwitterClone.Domain.Entities
{
    public class Retweet : BaseEntity
    {
        
     
      

        public Retweet() : base(Guid.NewGuid())
        {
           
        }

      

        public Guid UserId { get; private set; }

        public Guid TweetId { get; private set; }

        public string Comment { get; set; }

     
    }
}