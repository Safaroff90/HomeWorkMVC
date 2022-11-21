using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mentor.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}
