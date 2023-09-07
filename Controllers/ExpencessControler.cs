using Microsoft.AspNetCore.Mvc;
using prviProjekat_2_.Data;
using prviProjekat_2_.Models;
using System.Collections.Generic;

namespace prviProjekat_2_.Controllers
{
    public class ExpencessControler : Controller
    {
        private readonly ApplicationDBcontext _db;

        public ExpencessControler(ApplicationDBcontext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Expences> objList = _db.Expences;
            return View(objList);
           
        }

        //GET-Create
        public IActionResult Expences()
        {
            return View();
        }

        //POST-Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Expences(Expences obj)
        {
            if (ModelState.IsValid)
            {
                _db.Expences.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }

        // GET Delete
        public IActionResult Delete(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Expences.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        // POST Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Expences.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.Expences.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET Updat
        public IActionResult Update(int? id)
        {

            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Expences.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        //POST-Update

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Expences obj)
        {
            if (ModelState.IsValid)
            {
                _db.Expences.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }



    }
}
