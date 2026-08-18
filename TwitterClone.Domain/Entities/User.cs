

namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity,IFollowable,INotifiable
    {

        private List<Guid> _followers = new List<Guid>();
        private List<Guid> _inCommingNotifications = new List<Guid>();
        public User() : base(Guid.NewGuid()) 
        {
            
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public void Follow (Guid userId)
        {
            if(!_followers.Contains(userId))
            {
                _followers.Add(userId);
            }
        }
        public void Unfollow(Guid userId)
        {
            if(_followers.Contains(userId))
            {
                _followers.Remove(userId);
            }
        }

        public void AddNotification(Guid notificationId)
        {
            if(!_inCommingNotifications.Contains(notificationId))
            {
                _inCommingNotifications.Add(notificationId);
            }
        }

    }
}
