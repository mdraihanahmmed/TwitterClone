
namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity , ILikeable
    {

        private string _content;
        public static int MaxContentLength = 200;

        public Tweet(string content) : base(Guid.NewGuid())
        {
            _content = content;
        }

        public Tweet(Guid userId,string content) : base(Guid.NewGuid()) 
        {
            UserId = userId;
            _content = content;
        }
   

        public Guid UserId { get; private set;  }
       
        public void AddContent(string content)
        {
           _content = content;
        }
        public string Content { 
           get { return _content; }
           set { _content = value; }
        }
       
        public bool CanBeLiked()
        {
            return false;
        }
    }
}
