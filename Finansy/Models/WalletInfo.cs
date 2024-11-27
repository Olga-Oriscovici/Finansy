using System.ComponentModel.DataAnnotations;

namespace Finansy.Models
{
    public class WalletInfo
    {
        [Key]
        public int? Id { get; set; }
        [StringLength(100)]
        [Required]
        public string? Name { get; set; }
        [StringLength(100)]
        [Required]
        public string? Balance { get; set; }
    }
}
