using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using YumyApp.Models;

namespace YumyApp.DAL
{
    public class YummyDbContext:DbContext
    {
        public YummyDbContext(DbContextOptions<YummyDbContext> opt):base(opt)
        {
            
        }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<MealIngredient> MealIngredients { get; set; }
    }
}
