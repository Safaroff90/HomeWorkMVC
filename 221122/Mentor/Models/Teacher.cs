using System.ComponentModel.DataAnnotations;

namespace Mentor.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(35)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
    }
}
