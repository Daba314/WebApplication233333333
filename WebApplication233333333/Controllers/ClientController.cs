using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication233333333.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication233333333.Controllers
{
    public class ClientController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ClientController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            
            var displaydata = _db.Clients.ToList();
             return View(displaydata);
        }
        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Client nec) {
            if (ModelState.IsValid)
            {
                _db.Add(nec);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nec);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");

            }
            var getemptdetails = await _db.Clients.FindAsync(id);
            return View(getemptdetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Client nc)
        {
            if (ModelState.IsValid)
            {
                _db.Update(nc);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nc);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");

            }
            var getemptdetails = await _db.Clients.FindAsync(id);
            return View(getemptdetails);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");

            }
            var getemptdetails = await _db.Clients.FindAsync(id);
            return View(getemptdetails);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getemptdetails = await _db.Clients.FindAsync(id);
            _db.Clients.Remove(getemptdetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }



    }
}


