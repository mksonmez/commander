using System.ComponentModel.DataAnnotations;

namespace Commander.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        [MaxLength(120)]
        public string Line { get; set; }

        [Required]
        [MaxLength(40)]
        public string Platform { get; set; }
    }
}