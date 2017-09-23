using System;

namespace ASPNETCoreIdentitySample.ViewModels.Identity.Emails
{
    public class PasswordResetViewModel : EmailsBase
    {
        public Guid UserId { set; get; }
        public string Token { set; get; }
    }
}