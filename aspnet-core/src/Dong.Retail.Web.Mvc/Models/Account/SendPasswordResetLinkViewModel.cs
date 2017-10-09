using System.ComponentModel.DataAnnotations;

namespace Dong.Retail.Web.Models.Account
{
    public class SendPasswordResetLinkViewModel
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}