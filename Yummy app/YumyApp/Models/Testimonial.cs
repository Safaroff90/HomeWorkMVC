using System.ComponentModel.DataAnnotations;

namespace YumyApp.Models
{
    public class Testimonial
    {

        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Fullname { get; set; }

        [Required]
        [MaxLength(20)]
        public string Position { get; set; }

        [MaxLength(100)]
        public string Img { get; set; }

        [Required]
        public byte StarCount   { get; set; }

        [MaxLength(250)]
        public string Text { get; set; }

    }
}
