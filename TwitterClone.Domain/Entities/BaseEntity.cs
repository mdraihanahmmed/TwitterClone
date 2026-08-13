using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class BaseEntity
    {
       public Guid Id { get; private set; }
       public DateTime CreatedAt { get; private set; }
       public DateTime ModifiedAt { get; private set; }
       public DateTime CreatedBy { get; private set; }
       public DateTime ModifiedBy { get; private set; }


        public BaseEntity(Guid id)
        {
            Id = id;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
