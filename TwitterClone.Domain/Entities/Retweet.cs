namespace TwitterClone.Domain.Entities
{
    public class Retweet
    {
        private Guid _id;
        private Guid _tweetId;
        private Guid _userId;
        private DateTime _retweetedAt;

        public Guid Id
        {
            get { return _id; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public DateTime RetweetedAt
        {
            get { return _retweetedAt; }
        }
    }
}