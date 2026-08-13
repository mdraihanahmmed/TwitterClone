

namespace TwitterClone.Domain.Entities
{
    public class User : BaseEntity
    {
       
      
        public User() : base(Guid.NewGuid()) 
        {
            
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

    }
}
