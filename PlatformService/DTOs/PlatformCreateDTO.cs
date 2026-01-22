using System.ComponentModel.DataAnnotations;

namespace PlatformService.DTOs
{
    public class PlatformCreateDTO
    {
        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Publisher { get; set; }

        [Required]
        public required string Cost { get; set; }
    }
}
