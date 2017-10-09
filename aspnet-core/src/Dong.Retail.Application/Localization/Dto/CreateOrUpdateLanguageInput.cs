using System.ComponentModel.DataAnnotations;

namespace Dong.Retail.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}