

namespace TwitterClone.Domain.Entities
{
    public class Like
    {
        private Guid _id;
        private Guid _tweetId;
        private DateTime _likedAt;

        public Guid Id
        {
            get { return _id; }
        }
        public Guid TweetId
        {
            get { return _tweetId; }

        }
        public DateTime LikedAt
        {
            get { return _likedAt; }
        }
    }
}
