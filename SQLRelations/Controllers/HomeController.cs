using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLRelations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SQLRelations.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Index(int id)
        {
            Group group = _context.Groups.Include(g=>g.Students).FirstOrDefault(g => g.Id == id);
            if (group==null)
            {
                return Content("There is no group number you are looking for");
            }
            return View(group);
        }
    }
}
