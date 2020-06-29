using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication233333333.Models;

namespace WebApplication233333333.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _dz;
        public OrderController(ApplicationDbContext dz)
        {
            _dz = dz;
        }
        public IActionResult Index()
        {
            var displaydata = _dz.Orders.ToList();
            return View(displaydata);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Order nec)
        {
            if (ModelState.IsValid)
            {
                _dz.Add(nec);
                await _dz.SaveChangesAsync();
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
            var getemptdetails = await _dz.Orders.FindAsync(id);
            return View(getemptdetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Order nc)
        {
            if (ModelState.IsValid)
            {
                _dz.Update(nc);
                await _dz.SaveChangesAsync();
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
            var getemptdetails = await _dz.Orders.FindAsync(id);
            return View(getemptdetails);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");

            }
            var getemptdetails = await _dz.Orders.FindAsync(id);
            return View(getemptdetails);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getemptdetails = await _dz.Orders.FindAsync(id);
            _dz.Orders.Remove(getemptdetails);
            await _dz.SaveChangesAsync();
            return RedirectToAction("Index");
        }



    }
}

