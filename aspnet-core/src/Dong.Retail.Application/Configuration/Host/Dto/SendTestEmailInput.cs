using System.ComponentModel.DataAnnotations;
using Dong.Retail.Authorization.Users;

namespace Dong.Retail.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}