using System.Collections.Generic;
using ASPNETCoreIdentitySample.Common.WebToolkit;
using ASPNETCoreIdentitySample.Entities.Identity;
using System;

namespace ASPNETCoreIdentitySample.ViewModels.Identity
{
    public class DynamicRoleClaimsManagerViewModel
    {
        public string[] ActionIds { set; get; }

        public Guid RoleId { set; get; }

        public Role RoleIncludeRoleClaims { set; get; }

        public ICollection<MvcControllerViewModel> SecuredControllerActions { set; get; }
    }
}