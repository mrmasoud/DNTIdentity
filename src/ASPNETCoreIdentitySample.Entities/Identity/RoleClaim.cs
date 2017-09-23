﻿using ASPNETCoreIdentitySample.Entities.AuditableEntity;
using Microsoft.AspNetCore.Identity;
using System;

namespace ASPNETCoreIdentitySample.Entities.Identity
{
    /// <summary>
    /// More info: http://www.dotnettips.info/post/2577
    /// and http://www.dotnettips.info/post/2578
    /// </summary>
    public class RoleClaim : IdentityRoleClaim<Guid>, IAuditableEntity
    {
        public virtual Role Role { get; set; }
    }
}