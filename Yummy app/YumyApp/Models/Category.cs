using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YumyApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(35)]
        public string Name { get; set; }

        public List<Meal> Meals { get; set; }
    }
}
