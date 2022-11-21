using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using YumyApp.DAL;
using YumyApp.Models;
using YumyApp.ViewModels;

namespace YumyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly YummyDbContext _context;

        public HomeController(YummyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM home = new HomeVM
            {
                Testimonials = _context.Testimonials.ToList(),
                Meals = _context.Meals.ToList(),
                Categories = _context.Categories.Include(x=>x.Meals)
                .ThenInclude(x=>x.MealIngredients).ThenInclude(x=>x.Ingredient).ToList(),
            };

            return View(home);
        }




       
    }
}
