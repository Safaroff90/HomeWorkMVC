using System.Collections.Generic;
using YumyApp.Models;

namespace YumyApp.ViewModels
{
    public class HomeVM
    {
        public List<Testimonial> Testimonials { get; set; }
        public List<Meal> Meals { get; set; }
        public List<Category> Categories { get; set; }
    }
}
