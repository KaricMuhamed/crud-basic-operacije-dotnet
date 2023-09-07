using prviProjekat_2_.Models;
using prviProjekat_2_.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Collections;
using prviProjekat_2_.Models;
using System.Collections.Generic;

namespace prviProjekat_2_.Controllers
{
    public class ItemController1 : Controller
    {
        
        private readonly ApplicationDBcontext _db;

        public ItemController1(ApplicationDBcontext db)
        {
            _db = db;   
        }

        public IActionResult Index()
        {
            IEnumerable<Item> objList = _db.Items;

            return View(objList);
        }

        //GET-Create
        public IActionResult Create()
        {
            return View();
        }

        //POST-Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Item obj)
        {
            _db.Items.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
