

namespace TwitterClone.Domain.Entities
{
    public class User
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private DateTime _createdAt;
        private DateTime _modifiedAt;

        public User()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }

        public Guid Id
        { set { _firstName = value; } }
            


        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public DateTime ModifiedAt
        {
        get { return _modifiedAt; }
        set { _modifiedAt = value; }
        }
    }
}
