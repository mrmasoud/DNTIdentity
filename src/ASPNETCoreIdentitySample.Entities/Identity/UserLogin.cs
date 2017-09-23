using ASPNETCoreIdentitySample.Entities.AuditableEntity;
using Microsoft.AspNetCore.Identity;
using System;

namespace ASPNETCoreIdentitySample.Entities.Identity
{
    /// <summary>
    /// More info: http://www.dotnettips.info/post/2577
    /// and http://www.dotnettips.info/post/2578
    /// </summary>
    public class UserLogin : IdentityUserLogin<Guid>, IAuditableEntity
    {
        public virtual User User { get; set; }
    }
}