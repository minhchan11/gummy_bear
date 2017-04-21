using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using GummyBearKingdom.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GummyBearKingdom.Controllers
{
    public class HomeController : Controller
    {
        private GummyContext db = new GummyContext();
        public IActionResult Index()
        {
            return View(db.Gummies.ToList());
        }

        public IActionResult Details(int id)
        {
          var thisGummy = db.Gummies.FirstOrDefault(gummies => gummies.id == id);
          return View(thisGummy);
        }

        public IActionResult Create()
        {
          return View();
        }

        [HttpPost]
        public IActionResult Create(Gummy gummy)
        {
          db.Gummies.Add(gummy);
          db.SaveChanges();
          return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
          var thisGummy = db.Gummies.FirstOrDefault(gummies => gummies.id == id);
          return View(thisGummy);
        }

        [HttpPost]
        public IActionResult Edit(Gummy gummy)
        {
          db.Entry(gummy).State = EntityState.Modified;
          db.SaveChanges();
          return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
          var thisGummy = db.Gummies.FirstOrDefault(gummies => gummies.id == id);
          return View(thisGummy);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteThis(int id)
        {
          var thisGummy = db.Gummies.FirstOrDefault(gummies => gummies.id == id);
          db.Gummies.Remove(thisGummy);
          db.SaveChanges();
          return RedirectToAction("Index");
        }

    }
}
