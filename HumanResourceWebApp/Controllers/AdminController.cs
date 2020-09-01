using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResourceWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HumanResourceWebApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
