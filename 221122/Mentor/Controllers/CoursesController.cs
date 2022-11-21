using Mentor.DAL;
using Mentor.Models;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Mentor.ViewModels;


namespace Mentor.Controllers
{
    public class CoursesController : Controller
    {
        private readonly MentorDbContext _context;

        public CoursesController(MentorDbContext context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            CourseVM course = new CourseVM
            {

                Courses = _context.Courses.ToList(),
                Categories = _context.Categories.Include(x => x.Courses)
              .ThenInclude(x => x.CoursTeachers).ThenInclude(x => x.Teacher).ToList(),
            };
            return View(course);
        }
    }
}
