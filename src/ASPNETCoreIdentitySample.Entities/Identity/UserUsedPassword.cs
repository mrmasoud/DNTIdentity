using ASPNETCoreIdentitySample.Entities.AuditableEntity;
using System;

namespace ASPNETCoreIdentitySample.Entities.Identity
{
    public class UserUsedPassword : IAuditableEntity
    {
        public Guid Id { get; set; }

        public string HashedPassword { get; set; }

        public virtual User User { get; set; }
        public Guid UserId { get; set; }
    }
}