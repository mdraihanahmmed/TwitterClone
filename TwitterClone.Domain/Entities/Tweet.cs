
namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity
    {
      


        public Tweet(string content) : base(Guid.NewGuid())
        {
            Content = content;
        }
   

        public Guid UserId { get; private set;  }
       

        public string Content { get; set; }
       
    }
}
