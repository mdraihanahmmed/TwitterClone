namespace TwitterClone.Domain.Entities
{
    public class Follow  : BaseEntity
    {
      


        public Follow() : base(Guid.NewGuid())
        {
           
        }

      

        public Guid FollowerId { get; private set; }
      

        public Guid FollowingId { get; private set; }
      

       
    }
}