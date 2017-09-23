using System;

namespace ASPNETCoreIdentitySample.Entities.Identity
{
    public class AppDataProtectionKey
    {
        public Guid Id { get; set; }
        public string FriendlyName { get; set; }
        public string XmlData { get; set; }
    }
}