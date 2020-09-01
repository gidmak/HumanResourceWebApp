using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResourceWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HumanResourceWebApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public Admin Admins { get; set; }
        public AdminController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Upsert(int? id)
        {
            Admins = new Admin();
            if(id == null)
            {
                //Create a new admin
                return View(Admins);
            }
            //Update admin
            Admins = await _db.Admins.FirstOrDefaultAsync(u => u.Id == id);
            if(Admins == null)
            {
                return NotFound();
            }
            return View(Admins);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert()
        {
            if (ModelState.IsValid)
            {
                if(Admins.Id == 0)
                {
                    //Create new admin record
                    _db.Admins.Add(Admins);
                }
                else
                {
                    //Update admin record
                    _db.Admins.Update(Admins);
                }
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(Admins);
        }
        #region API Calls
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data = await _db.Admins.ToListAsync() });
        }
        #endregion
    }
}
