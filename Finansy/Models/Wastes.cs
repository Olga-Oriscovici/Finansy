using System.ComponentModel.DataAnnotations;

namespace Finansy.Models
{
    public class Wastes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required]
        [StringLength(50)]
        public string? Description { get; set; }
        [Required]
        [StringLength(50)]
        public string? Amount { get; set; }
    }
}
