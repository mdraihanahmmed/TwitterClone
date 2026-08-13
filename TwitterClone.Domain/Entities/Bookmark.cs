namespace TwitterClone.Domain.Entities
{
    public class Bookmark : BaseEntity
    {
 
        private Guid _userId;
        private Guid _tweetId;
       

        public Bookmark() : base(Guid.NewGuid())
        {
          
        }

      

        public Guid UserId { get; private set; }
     

        public Guid TweetId { get; private set; }
      

     
    }
}