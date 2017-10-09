using System.ComponentModel.DataAnnotations;

namespace Dong.Retail.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}