using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dtos
{
    public class PlatformCreatedDto
    {
        [Required]
        public string Name { get; set; } = default!;

        [Required]
        public string Publisher { get; set; } = default!;

        [Required]
        public string Cost { get; set; } = default!;
    }
}