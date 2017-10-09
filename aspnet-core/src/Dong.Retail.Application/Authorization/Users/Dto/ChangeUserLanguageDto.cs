using System.ComponentModel.DataAnnotations;

namespace Dong.Retail.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
